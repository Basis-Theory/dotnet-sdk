using System.Text.Json;
using NUnit.Framework;

#nullable enable

namespace BasisTheory.Client.Test;

[TestFixture]
public class TestClient
{
    [Test]
    public async Task ShouldGetTenantSelf()
    {
        var client = GetManagementClient();
        var actual = await client.Tenants.Self.GetAsync();
        Assert.That(actual.Name, Is.EqualTo("SDK Integration Tests"));
    }

    [Test]
    public async Task ShouldPerformTokenLifecycle()
    {
        var client = GetPrivateClient();
        var managementClient = GetManagementClient();

        var cardNumber = "6011000990139424";
        var tokenId = await CreateToken(client, cardNumber);
        await GetAndValidateCardNumber(client, tokenId, cardNumber);

        // var updateCardNumber = "4242424242424242";
        // await UpdateTokenb(client, tokenId, cardNumber);
        // GetAndValidateCardNumber(client, tokenId, updateCardNumber);

        // Create Application
        var application = await managementClient.Applications.CreateAsync(new CreateApplicationRequest
        {
            Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
            Type = "private",
            Permissions = ["token:use"]
        });
        var applicationId = application.Id;

        // Proxies
        var proxyId = await CreateProxy(managementClient, applicationId);
        await managementClient.Proxies.DeleteAsync(proxyId);

        // Reactors
        var reactorId = await CreateReactor(managementClient, applicationId);
        await React(client, reactorId);
        await managementClient.Reactors.DeleteAsync(reactorId);

        // Clean-up
        await DeleteApplication(managementClient, applicationId);
        await EnsureTokenIsDeleted(client, tokenId);
    }

    private static async Task EnsureTokenIsDeleted(BasisTheory client, string? tokenId)
    {
        await client.Tokens.DeleteAsync(tokenId);
        try
        {
            await client.Tokens.GetAsync(tokenId);
            Assert.Fail("Should have return 404 for not token");
        }
        catch (Exception e)
        {
            Assert.That(e, Is.TypeOf<NotFoundError>());
        }
    }

    private static async Task DeleteApplication(BasisTheory managementClient, string? applicationId)
    {
        await managementClient.Applications.DeleteAsync(applicationId);
    }

    private static async Task React(BasisTheory client, string? reactorId)
    {
        var args = new Dictionary<string, string>
        {
            {"key1", "Key1-" + Guid.NewGuid()},
            {"key2", "Key2-" + Guid.NewGuid()},
        };
        var react = await client.Reactors.ReactAsync(reactorId,
            new ReactRequest
            {
                Args = args
            });
        Assert.That(react.Raw.GetJsonElementValue<string>("key1"), Is.EqualTo(args["key1"]));
        Assert.That(react.Raw.GetJsonElementValue<string>("key2"), Is.EqualTo(args["key2"]));
    }

    private static async Task<string?> CreateReactor(BasisTheory managementClient, string? appliationId)
    {
        var reactor = await managementClient.Reactors.CreateAsync(new CreateReactorRequest
        {
            Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
            Code = "module.exports = function (req) {return {raw: req.args}}",
            Application = new Application
            {
                Id = appliationId
            }
        });
        var reactorId = reactor.Id;
        return reactorId;
    }

    private static async Task<string?> CreateProxy(BasisTheory client, string? appliationId)
    {
        var proxy = await client.Proxies.CreateAsync(new CreateProxyRequest
        {
            Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
            DestinationUrl = "https://echo.basistheory.com/" + Guid.NewGuid(),
            Application = new Application
            {
                Id = appliationId
            }
        });
        var proxyId = proxy.Id;
        return proxyId;
    }

    private static async Task UpdateTokenb(BasisTheory client, string? tokenId, string cardNumber)
    {
        await client.Tokens.UpdateAsync(tokenId,
            new UpdateTokenRequest
            {
                Data = new
                {
                    number = cardNumber,
                    expiration_month = 4,
                    expiration_year = 2025,
                    cvc = 123
                },
            });
    }

    private static async Task GetAndValidateCardNumber(BasisTheory client, string? tokenId, string cardNumber)
    {
        var token = await client.Tokens.GetAsync(tokenId!);
        dynamic actual = token.Data!;
        Assert.That(token.Data.GetJsonElementValue<string>("number"), Is.EqualTo(cardNumber));
    }

    private static async Task<string?> CreateToken(BasisTheory client, string cardNumber)
    {
        var token = await client.Tokens.CreateAsync(new CreateTokenRequest
        {
            Type = "card",
            Data = new
            {
                number = cardNumber,
                expiration_month = 4,
                expiration_year = 2025,
                cvc = 123
            },
            Metadata = new Dictionary<string, string?>
            {
                {"customer_id", "3181"}
            },
            SearchIndexes =
            [
                "{{ data.expiration_month }}", "{{ data.number | last4 }}"
            ],
            FingerprintExpression = "{{ data.number }}",
            Mask = new
            {
                number = "{{ data.number, reveal_last: 4 }}",
                cvc = "{{ data.cvc }}"
            },
            DeduplicateToken = false,
            Containers = ["/pci/high/"]
        });
        var tokenId = token.Id;
        return tokenId;
    }

    private static BasisTheory GetPrivateClient()
    {
        return new BasisTheory(Environment.GetEnvironmentVariable("BT_PVT_API_KEY"),
            new ClientOptions
            {
                BaseUrl = Environment.GetEnvironmentVariable("BT_API_URL")!,
            });
    }

    private static BasisTheory GetManagementClient()
    {
        return new BasisTheory(Environment.GetEnvironmentVariable("BT_MGT_API_KEY"),
            new ClientOptions
            {
                BaseUrl = Environment.GetEnvironmentVariable("BT_API_URL")!,
            });
    }
}

public static class ObjectExtensions
{
    public static T GetJsonElementValue<T>(this object obj, string propertyName, T defaultValue = default)
    {
        if (obj is JsonElement jsonElement && jsonElement.TryGetProperty(propertyName, out JsonElement property))
        {
            return property.ValueKind switch
            {
                JsonValueKind.Number when typeof(T) == typeof(int) => (T)(object)property.GetInt32(),
                JsonValueKind.Number when typeof(T) == typeof(long) => (T)(object)property.GetInt64(),
                JsonValueKind.Number when typeof(T) == typeof(double) => (T)(object)property.GetDouble(),
                JsonValueKind.String => (T)(object)property.GetString(),
                JsonValueKind.True or JsonValueKind.False => (T)(object)property.GetBoolean(),
                _ => defaultValue
            };
        }
        return defaultValue;
    }
}