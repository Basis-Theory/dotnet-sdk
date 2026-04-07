using System.Text.RegularExpressions;
using BasisTheory.Client.Agentic;
using BasisTheory.Client.Agentic.Agents;
using BasisTheory.Client.Agentic.Agents.Instructions;
using BasisTheory.Client.Agentic.Enrollments;
using NUnit.Framework;

namespace BasisTheory.Client.Test;

[TestFixture]
public class AgenticTests
{
    private static BasisTheory GetClient()
    {
        return new BasisTheory(Environment.GetEnvironmentVariable("BT_PVT_TEST_API_KEY"),
            clientOptions: new ClientOptions
            {
                BaseUrl = Environment.GetEnvironmentVariable("BT_API_URL")!,
            });
    }

    private static async Task<string> CreateCardToken(BasisTheory client, string cardNumber)
    {
        var token = await client.Tokens.CreateAsync(new CreateTokenRequest
        {
            Type = "card",
            Data = new
            {
                number = cardNumber,
                expiration_month = 12,
                expiration_year = 2030,
                cvc = 123,
            },
        });
        return token.Id!;
    }

    private static DeviceContext CreateDeviceContext()
    {
        return new DeviceContext
        {
            ScreenHeight = 1080,
            ScreenWidth = 1920,
            UserAgentString = "dotnet-sdk-test",
            LanguageCode = "en-US",
            TimeZone = "America/New_York",
            JavaScriptEnabled = true,
            ClientDeviceId = Guid.NewGuid().ToString(),
            ClientReferenceId = Guid.NewGuid().ToString(),
            PlatformType = DeviceContextPlatformType.Web,
        };
    }

    private static async Task<Enrollment> CreateAndVerifyEnrollment(
        BasisTheory client, string cardNumber, string email, IEnumerable<string>? agentIds = null)
    {
        var tokenId = await CreateCardToken(client, cardNumber);
        var enrollment = await client.Agentic.Enrollments.CreateAsync(new CreateEnrollmentRequest
        {
            TokenId = tokenId,
            Consumer = new Consumer { Email = email },
            AgentIds = agentIds,
        });

        // Start verification
        var verifyResponse = await client.Agentic.Enrollments.Verify.StartAsync(enrollment.Id!, new StartVerificationRequest
        {
            DeviceContext = CreateDeviceContext(),
        });

        // Auto-approved cards are already verified after verify.start
        if (verifyResponse.Status != VerificationResponseStatus.Approved)
        {
            // OTP flow: select method, submit OTP, complete
            var methods = verifyResponse.Methods?.ToList();
            if (methods != null && methods.Count > 0)
            {
                await client.Agentic.Enrollments.Verify.MethodAsync(enrollment.Id!, new SelectMethodRequest
                {
                    MethodId = methods[0].Id!,
                });
            }

            await client.Agentic.Enrollments.Verify.OtpAsync(enrollment.Id!, new SubmitOtpRequest
            {
                OtpCode = "123456",
            });

            await client.Agentic.Enrollments.Verify.CompleteAsync(enrollment.Id!, new CompleteVerificationRequest());
        }

        return await client.Agentic.Enrollments.GetAsync(enrollment.Id!);
    }

    [Test]
    public async Task ShouldSupportAgentLifecycle()
    {
        var client = GetClient();

        // Create
        var agentName = "(Deletable) dotnet-SDK-agent-" + Guid.NewGuid();
        var agent = await client.Agentic.Agents.CreateAsync(new CreateAgentRequest
        {
            Name = agentName,
        });
        Assert.That(agent.Id, Is.Not.Null);
        Assert.That(agent.Name, Is.EqualTo(agentName));
        Assert.That(agent.Status, Is.EqualTo("active"));
        Assert.That(agent.EnrollmentIds, Is.Not.Null);
        Assert.That(agent.CreatedAt, Is.Not.Null);

        // Get and verify all fields match
        var retrieved = await client.Agentic.Agents.GetAsync(agent.Id!);
        Assert.That(retrieved.Id, Is.EqualTo(agent.Id));
        Assert.That(retrieved.Name, Is.EqualTo(agent.Name));
        Assert.That(retrieved.Status, Is.EqualTo("active"));
        Assert.That(retrieved.EnrollmentIds, Is.EqualTo(agent.EnrollmentIds));
        Assert.That(retrieved.CreatedAt, Is.EqualTo(agent.CreatedAt));

        // Update
        var updatedName = "(Deletable) dotnet-SDK-agent-updated-" + Guid.NewGuid();
        var updated = await client.Agentic.Agents.UpdateAsync(agent.Id!, new UpdateAgentRequest
        {
            Name = updatedName,
        });
        Assert.That(updated.Id, Is.EqualTo(agent.Id));
        Assert.That(updated.Name, Is.EqualTo(updatedName));
        Assert.That(updated.Status, Is.EqualTo("active"));
        Assert.That(updated.CreatedAt, Is.EqualTo(agent.CreatedAt));

        // Delete
        await client.Agentic.Agents.DeleteAsync(agent.Id!);

        // Verify deleted
        try
        {
            await client.Agentic.Agents.GetAsync(agent.Id!);
            Assert.Fail("Should have raised a 404 for agent not found");
        }
        catch (Exception e)
        {
            Assert.That(e, Is.TypeOf<NotFoundError>());
        }
    }

    [Test]
    [CancelAfter(30000)]
    public async Task ShouldSupportAutoApprovedEnrollmentLifecycle()
    {
        var client = GetClient();

        // Create and verify enrollment (passkey bypass card)
        var enrollment = await CreateAndVerifyEnrollment(client, "4000056655665556", "sdk-test@example.com");
        Assert.That(enrollment.Id, Is.Not.Null);
        Assert.That(enrollment.Status, Is.EqualTo(EnrollmentStatus.Active));
        Assert.That(enrollment.Provider, Is.Not.Null);
        Assert.That(enrollment.CreatedAt, Is.Not.Null);

        // Verify card object fields
        Assert.That(enrollment.Card, Is.Not.Null);
        Assert.That(enrollment.Card?.Brand, Is.EqualTo(AgenticCardBrand.Visa));
        Assert.That(enrollment.Card?.Bin, Is.Not.Null);
        Assert.That(enrollment.Card?.Last4, Is.EqualTo("5556"));
        Assert.That(enrollment.Card?.ExpirationMonth, Is.Not.Null);
        Assert.That(enrollment.Card?.ExpirationYear, Is.Not.Null);

        // Get enrollment and verify all fields match
        var retrieved = await client.Agentic.Enrollments.GetAsync(enrollment.Id!);
        Assert.That(retrieved.Id, Is.EqualTo(enrollment.Id));
        Assert.That(retrieved.Status, Is.EqualTo(EnrollmentStatus.Active));
        Assert.That(retrieved.Provider, Is.EqualTo(enrollment.Provider));
        Assert.That(retrieved.Card?.Brand, Is.EqualTo(enrollment.Card?.Brand));
        Assert.That(retrieved.Card?.Bin, Is.EqualTo(enrollment.Card?.Bin));
        Assert.That(retrieved.Card?.Last4, Is.EqualTo(enrollment.Card?.Last4));
        Assert.That(retrieved.Card?.ExpirationMonth, Is.EqualTo(enrollment.Card?.ExpirationMonth));
        Assert.That(retrieved.Card?.ExpirationYear, Is.EqualTo(enrollment.Card?.ExpirationYear));
        Assert.That(retrieved.CreatedAt, Is.EqualTo(enrollment.CreatedAt));

        // List enrollments and verify structure (auto-paginated)
        var enrollments = await client.Agentic.Enrollments.ListAsync(new EnrollmentsListRequest());
        Enrollment? listed = null;
        await foreach (var e in enrollments)
        {
            if (e.Id == enrollment.Id)
            {
                listed = e;
                break;
            }
        }
        Assert.That(listed, Is.Not.Null);
        Assert.That(listed?.Status, Is.EqualTo(EnrollmentStatus.Active));
        Assert.That(listed?.Card?.Last4, Is.EqualTo("5556"));

        // Delete enrollment
        await client.Agentic.Enrollments.DeleteAsync(enrollment.Id!);
    }

    [Test]
    [CancelAfter(30000)]
    public async Task ShouldSupportOtpVerificationFlow()
    {
        var client = GetClient();

        // Create a card token (OTP challenge Visa test card)
        var tokenId = await CreateCardToken(client, "4000000000000002");

        // Create enrollment (will be pending_verification)
        var enrollment = await client.Agentic.Enrollments.CreateAsync(new CreateEnrollmentRequest
        {
            TokenId = tokenId,
            Consumer = new Consumer
            {
                Email = "sdk-test-otp@example.com",
            },
        });
        Assert.That(enrollment.Id, Is.Not.Null);
        Assert.That(enrollment.Status, Is.EqualTo(EnrollmentStatus.PendingVerification));
        Assert.That(enrollment.Provider, Is.Not.Null);
        Assert.That(enrollment.CreatedAt, Is.Not.Null);

        // Verify card object on initial create response
        Assert.That(enrollment.Card, Is.Not.Null);
        Assert.That(enrollment.Card?.Brand, Is.EqualTo(AgenticCardBrand.Visa));
        Assert.That(enrollment.Card?.Bin, Is.Not.Null);
        Assert.That(enrollment.Card?.Last4, Is.EqualTo("0002"));
        Assert.That(enrollment.Card?.ExpirationMonth, Is.Not.Null);
        Assert.That(enrollment.Card?.ExpirationYear, Is.Not.Null);

        // Start verification - expect challenge with OTP methods
        var verifyResponse = await client.Agentic.Enrollments.Verify.StartAsync(enrollment.Id!, new StartVerificationRequest
        {
            DeviceContext = CreateDeviceContext(),
        });
        Assert.That(verifyResponse.Status, Is.EqualTo(VerificationResponseStatus.Challenge));
        Assert.That(verifyResponse.Methods, Is.Not.Null);
        var methods = verifyResponse.Methods!.ToList();
        Assert.That(methods.Count, Is.GreaterThan(0));
        Assert.That(methods[0].Id, Is.Not.Null);
        Assert.That(methods[0].Type, Is.Not.Null);

        // Select verification method
        if (methods.Count > 0)
        {
            await client.Agentic.Enrollments.Verify.MethodAsync(enrollment.Id!, new SelectMethodRequest
            {
                MethodId = methods[0].Id!,
            });
        }

        // Submit OTP (mock accepts any code)
        var otpResponse = await client.Agentic.Enrollments.Verify.OtpAsync(enrollment.Id!, new SubmitOtpRequest
        {
            OtpCode = "123456",
        });
        Assert.That(otpResponse.Status, Is.EqualTo(VerificationResponseStatus.DeviceBound));

        // Complete verification
        var completeResponse = await client.Agentic.Enrollments.Verify.CompleteAsync(enrollment.Id!, new CompleteVerificationRequest());
        Assert.That(completeResponse.Status, Is.EqualTo(VerificationResponseStatus.Verified));

        // Verify enrollment is now active with all fields
        var completed = await client.Agentic.Enrollments.GetAsync(enrollment.Id!);
        Assert.That(completed.Id, Is.EqualTo(enrollment.Id));
        Assert.That(completed.Status, Is.EqualTo(EnrollmentStatus.Active));
        Assert.That(completed.Provider, Is.EqualTo(enrollment.Provider));
        Assert.That(completed.Card?.Brand, Is.EqualTo(AgenticCardBrand.Visa));
        Assert.That(completed.Card?.Last4, Is.EqualTo("0002"));
        Assert.That(completed.CreatedAt, Is.EqualTo(enrollment.CreatedAt));

        // Cleanup
        await client.Agentic.Enrollments.DeleteAsync(enrollment.Id!);
    }

    [Test]
    [CancelAfter(30000)]
    public async Task ShouldSupportInstructionLifecycleWithCredentials()
    {
        var client = GetClient();

        // Setup: create agent and auto-approved enrollment
        var agent = await client.Agentic.Agents.CreateAsync(new CreateAgentRequest
        {
            Name = "(Deletable) dotnet-SDK-instruction-agent-" + Guid.NewGuid(),
        });

        var enrollment = await CreateAndVerifyEnrollment(client, "4000056655665556", "sdk-test-instructions@example.com", [agent.Id!]);
        Assert.That(enrollment.Status, Is.EqualTo(EnrollmentStatus.Active));

        // Create instruction
        var expiresAt = DateTime.UtcNow.AddDays(7);

        var instruction = await client.Agentic.Agents.Instructions.CreateAsync(agent.Id!, new CreateInstructionRequest
        {
            EnrollmentId = enrollment.Id!,
            Amount = new Amount
            {
                Value = "25.00",
                Currency = "USD",
            },
            Description = "(Deletable) dotnet-SDK test purchase",
            ExpiresAt = expiresAt,
        });
        Assert.That(instruction.Id, Is.Not.Null);
        Assert.That(instruction.EnrollmentId, Is.EqualTo(enrollment.Id));
        Assert.That(instruction.Status, Is.EqualTo(InstructionStatus.PendingVerification));
        Assert.That(instruction.Amount, Is.Not.Null);
        Assert.That(instruction.Amount?.Value, Is.EqualTo("25.00"));
        Assert.That(instruction.Amount?.Currency, Is.EqualTo("USD"));
        Assert.That(instruction.ExpiresAt, Is.Not.Null);
        Assert.That(instruction.CreatedAt, Is.Not.Null);

        // Get instruction and verify all fields match
        var retrieved = await client.Agentic.Agents.Instructions.GetAsync(agent.Id!, instruction.Id!);
        Assert.That(retrieved.Id, Is.EqualTo(instruction.Id));
        Assert.That(retrieved.EnrollmentId, Is.EqualTo(instruction.EnrollmentId));
        Assert.That(retrieved.Status, Is.EqualTo(instruction.Status));
        Assert.That(retrieved.Amount?.Value, Is.EqualTo(instruction.Amount?.Value));
        Assert.That(retrieved.Amount?.Currency, Is.EqualTo(instruction.Amount?.Currency));
        Assert.That(retrieved.CreatedAt, Is.EqualTo(instruction.CreatedAt));

        // Update instruction
        var updated = await client.Agentic.Agents.Instructions.UpdateAsync(agent.Id!, instruction.Id!, new UpdateInstructionRequest
        {
            Amount = new Amount
            {
                Value = "50.00",
                Currency = "USD",
            },
        });
        Assert.That(updated.Id, Is.EqualTo(instruction.Id));
        Assert.That(updated.Amount?.Value, Is.EqualTo("50.00"));
        Assert.That(updated.Amount?.Currency, Is.EqualTo("USD"));
        Assert.That(updated.EnrollmentId, Is.EqualTo(enrollment.Id));
        Assert.That(updated.CreatedAt, Is.EqualTo(instruction.CreatedAt));

        // List instructions (auto-paginated)
        var instructions = await client.Agentic.Agents.Instructions.ListAsync(agent.Id!, new InstructionsListRequest());
        Instruction? listed = null;
        await foreach (var i in instructions)
        {
            if (i.Id == instruction.Id)
            {
                listed = i;
                break;
            }
        }
        Assert.That(listed, Is.Not.Null);
        Assert.That(listed?.EnrollmentId, Is.EqualTo(enrollment.Id));
        Assert.That(listed?.Amount?.Value, Is.EqualTo("50.00"));

        // Verify instruction (required before credentials can be retrieved)
        var instrVerifyResponse = await client.Agentic.Agents.Instructions.Verify.StartAsync(
            agent.Id!,
            instruction.Id!,
            new StartVerificationRequest
            {
                DeviceContext = CreateDeviceContext(),
            });
        // Passkey bypass card returns verified immediately
        Assert.That(instrVerifyResponse.Status, Is.EqualTo(VerificationResponseStatus.Verified));

        // Confirm instruction is now approved
        var approved = await client.Agentic.Agents.Instructions.GetAsync(agent.Id!, instruction.Id!);
        Assert.That(approved.Status, Is.EqualTo(InstructionStatus.Approved));
        Assert.That(approved.Id, Is.EqualTo(instruction.Id));
        Assert.That(approved.EnrollmentId, Is.EqualTo(enrollment.Id));

        // Get credentials
        var credentials = await client.Agentic.Agents.Instructions.Credentials.CreateAsync(
            agent.Id!,
            instruction.Id!,
            new GetCredentialsRequest
            {
                Merchant = new AgenticMerchant
                {
                    Name = "(Deletable) Test Merchant",
                    Url = "https://example.com",
                    CountryCode = "US",
                },
            });
        Assert.That(credentials.Card?.Number, Is.Not.Null);
        Assert.That(credentials.Card?.ExpirationMonth, Is.Not.Null);
        Assert.That(credentials.Card?.ExpirationYear, Is.Not.Null);
        Assert.That(credentials.Card?.Cvc, Is.Not.Null);

        // Verify mock virtual card number format: 400000100000 + last 4
        Assert.That(Regex.IsMatch(credentials.Card!.Number!, @"^400000100000\d{4}$"), Is.True);

        // Delete instruction
        await client.Agentic.Agents.Instructions.DeleteAsync(agent.Id!, instruction.Id!);

        // Cleanup
        await client.Agentic.Enrollments.DeleteAsync(enrollment.Id!);
        await client.Agentic.Agents.DeleteAsync(agent.Id!);
    }

    [Test]
    [CancelAfter(30000)]
    public async Task ShouldSupportListingInstructionsFilteredByEnrollment()
    {
        var client = GetClient();

        // Setup
        var agent = await client.Agentic.Agents.CreateAsync(new CreateAgentRequest
        {
            Name = "(Deletable) dotnet-SDK-filter-agent-" + Guid.NewGuid(),
        });

        var enrollment = await CreateAndVerifyEnrollment(client, "4000056655665556", "sdk-test-filter@example.com", [agent.Id!]);

        var expiresAt = DateTime.UtcNow.AddDays(7);

        var instruction = await client.Agentic.Agents.Instructions.CreateAsync(agent.Id!, new CreateInstructionRequest
        {
            EnrollmentId = enrollment.Id!,
            Amount = new Amount { Value = "10.00", Currency = "USD" },
            Description = "(Deletable) dotnet-SDK filter test",
            ExpiresAt = expiresAt,
        });

        // Verify created instruction fields
        Assert.That(instruction.Id, Is.Not.Null);
        Assert.That(instruction.EnrollmentId, Is.EqualTo(enrollment.Id));
        Assert.That(instruction.Status, Is.EqualTo(InstructionStatus.PendingVerification));
        Assert.That(instruction.Amount?.Value, Is.EqualTo("10.00"));
        Assert.That(instruction.Amount?.Currency, Is.EqualTo("USD"));
        Assert.That(instruction.ExpiresAt, Is.Not.Null);
        Assert.That(instruction.CreatedAt, Is.Not.Null);

        // List with enrollment filter (auto-paginated)
        var filtered = await client.Agentic.Agents.Instructions.ListAsync(agent.Id!, new InstructionsListRequest
        {
            EnrollmentId = enrollment.Id!,
        });
        var filteredItems = new List<Instruction>();
        await foreach (var i in filtered)
        {
            filteredItems.Add(i);
        }
        Assert.That(filteredItems.Count, Is.GreaterThan(0));
        // Verify all returned instructions belong to the filtered enrollment
        Assert.That(filteredItems.All(i => i.EnrollmentId == enrollment.Id), Is.True);

        // Cleanup
        await client.Agentic.Agents.Instructions.DeleteAsync(agent.Id!, instruction.Id!);
        await client.Agentic.Enrollments.DeleteAsync(enrollment.Id!);
        await client.Agentic.Agents.DeleteAsync(agent.Id!);
    }
}
