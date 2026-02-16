using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using NUnit.Framework;

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
    public async Task ShouldPerformProxyLifecycle()
    {
        var client = GetManagementClient();
        var applicationId = await CreateApplication(client);
        var proxy = await client.Proxies.CreateAsync(new CreateProxyRequest
        {
            Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
            DestinationUrl = "https://example.com/api",
            RequestTransform = new ProxyTransform
            {
                Code = @"
                  module.exports = async function (req) {
                    // Do something with req.configuration.SERVICE_API_KEY

                    return {
                      headers: req.args.headers,
                      body: req.args.body
                    };
                  };
                "
            },
            ResponseTransform = new ProxyTransform
            {
                Code = @"
                  module.exports = async function (req) {
                    // Do something with req.configuration.SERVICE_API_KEY

                    return {
                      headers: req.args.headers,
                      body: req.args.body
                    };
                  };
                "
            },
            Configuration = new Dictionary<string, string?>
            {
                { "SERVICE_API_KEY", "key_abcd1234" }
            },
            Application = new Application
            {
                Id = applicationId
            },
            RequireAuth = true
        });
        var proxyId = proxy.Id;

        var updatedProxy = await client.Proxies.UpdateAsync(
            proxyId,
            new UpdateProxyRequest
            {
                Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
                DestinationUrl = "https://example.com/api",
                RequestTransform = new ProxyTransform
                {
                    Code = @"
                  module.exports = async function (req) {
                    // Do something with req.configuration.SERVICE_API_KEY

                    return {
                      headers: req.args.headers,
                      body: req.args.body
                    };
                  };
                "
                },
                ResponseTransform = new ProxyTransform
                {
                    Code = @"
                  module.exports = async function (req) {
                    // Do something with req.configuration.SERVICE_API_KEY

                    return {
                      headers: req.args.headers,
                      body: req.args.body
                    };
                  };
                "
                },
                Configuration = new Dictionary<string, string?>
                {
                    { "SERVICE_API_KEY", "key_abcd1234" }
                },
                Application = new Application
                {
                    Id = applicationId
                },
                RequireAuth = true
            }
        );
        Assert.That(updatedProxy.Id, Is.EqualTo(proxyId));

        await client.Proxies.PatchAsync(
            proxyId,
            new PatchProxyRequest
            {
                Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
                DestinationUrl = "https://example.com/api",
                Configuration = new Dictionary<string, string?> {
                    { "SERVICE_API_KEY", "key_abcd1234" }
                },
            }
        );

        await client.Proxies.DeleteAsync(proxyId);
        await client.Applications.DeleteAsync(applicationId);
    }

    [Test]
    public async Task ShouldPerformReactorLifecycle()
    {
        var managementClient = GetManagementClient();
        var applicationId = await CreateApplication(managementClient);
        var reactor = await managementClient.Reactors.CreateAsync(new CreateReactorRequest
        {
            Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
            Code = @"
                    module.exports = async function (req) {
                      // Do something with req.configuration.SERVICE_API_KEY

                      return {
                        raw: {
                          foo: ""bar""
                        }
                      };
                    };",
            Configuration = new Dictionary<string, string?>
            {
                { "SERVICE_API_KEY", "key_abcd1234" }
            },
            Application = new Application
            {
                Id = applicationId
            }
        });
        var reactorId = reactor.Id;

        var updatedReactor = await managementClient.Reactors.UpdateAsync(
            reactorId,
            new UpdateReactorRequest
            {
                Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
                Code = @"
                    module.exports = async function (req) {
                      // Do something with req.configuration.SERVICE_API_KEY

                      return {
                        raw: {
                          foo: ""bar""
                        }
                      };
                    };",
                Configuration = new Dictionary<string, string?>
                {
                    { "SERVICE_API_KEY", "key_abcd1234" }
                },
                Application = new Application
                {
                    Id = applicationId
                }
            }
        );
        Assert.That(updatedReactor.Id, Is.EqualTo(reactorId));

        await managementClient.Reactors.PatchAsync(
            reactorId,
            new PatchReactorRequest
            {
                Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
                Configuration = new Dictionary<string, string?>
                {
                    { "SERVICE_API_KEY", "key_abcd1234" }
                }
            }
        );

        var client = GetPrivateClient();
        var reactResponse = await client.Reactors.ReactAsync(
            reactorId,
            new
            {
                args = new
                {
                    foo = "bar"
                }
            }
        );
        Assert.That(reactResponse.Raw!.GetJsonElementValue<string>("foo"), Is.EqualTo("bar"));

        var asyncReactResponse = await client.Reactors.ReactAsyncAsync(
            reactorId,
            new
            {
                args = new
                {
                    foo = "bar"
                }
            }
        );
        AssertIsGuid(asyncReactResponse.AsyncReactorRequestId);

        await managementClient.Reactors.DeleteAsync(reactorId);
        await managementClient.Applications.DeleteAsync(applicationId);
    }

    [Test]
    public async Task ShouldPerformTokenLifecycle()
    {
        var client = GetPrivateClient();
        var managementClient = GetManagementClient();

        var cardNumber = "6011000990139424";
        var tokenId = await CreateToken(client, cardNumber);
        await GetAndValidateCardNumber(client, tokenId, cardNumber);

        var updateCardNumber = "4242424242424242";
        await UpdateToken(client, tokenId, updateCardNumber);
        GetAndValidateCardNumber(client, tokenId, updateCardNumber);

        // Create Application
        var applicationId = await CreateApplication(managementClient);

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

    [Test]
    [Ignore("Correlation ID is currently not supportedin RequestOptions")]
    public async Task ShouldSupportCorrelationId()
    {
        var client = GetPrivateClient();
        var options = new RequestOptions
        {
            // CorrelationId = Guid.NewGuid().ToString()
        };
    }

    [Test]
    public async Task ShouldSupportIdempotencyHeader()
    {
        var client = GetPrivateClient();
        var options = new IdempotentRequestOptions
        {
            IdempotencyKey = Guid.NewGuid().ToString(),
        };

        var firstTokenId = await CreateToken(client, "6011000990139424", options);
        var secondTokenId = await CreateToken(client, "4242424242424242", options);

        Assert.That(secondTokenId, Is.EqualTo(firstTokenId));
    }

    [Test]
    public async Task ShouldSupportAutoPaginationOnListV2()
    {
        var client = GetPrivateClient();
        const int pageSize = 3;
        var tokens = await client.Tokens.ListV2Async(new TokensListV2Request
        {
            Size = pageSize
        }, null);

        var count = 0;
        await foreach (Token token in tokens)
        {
            AssertIsGuid(token.Id);
            count++;
            if (count > pageSize)
                break;
        }

        Assert.That(count, Is.GreaterThan(pageSize));
    }

    [Test]
    public async Task ShouldCreateAndUpdateToken()
    {
        var client = GetPrivateClient();
        var token = await client.Tokens.CreateAsync(new CreateTokenRequest
        {
            Type = "token",
            Data = "Sensitive Value",
            Mask = "{{ data | reveal_last: 4 }}",
            Containers = ["/general/high/"],
            Metadata = new Dictionary<string, string?>
            {
                { "nonSensitiveField", "Non-Sensitive Value" }
            },
            SearchIndexes = ["{{ data }}", "{{ data | last4 }}"],
            FingerprintExpression = "{{ data }}",
            DeduplicateToken = true,
            ExpiresAt = "8/26/2030 7:23:57 PM -07:00",
        });
        AssertIsGuid(token.Id);

        var updatedToken = await client.Tokens.UpdateAsync(
            token.Id,
            new UpdateTokenRequest
            {
                Data = "Sensitive Value",
                Mask = "{{ data | reveal_last: 4 }}",
                Containers = ["/general/high/"],
                Metadata = new Dictionary<string, string?>
                {
                    { "nonSensitiveField", "Non-Sensitive Value" }
                },
                SearchIndexes = ["{{ data }}", "{{ data | last4 }}"],
                FingerprintExpression = "{{ data }}",
                DeduplicateToken = true,
            }
        );
        Assert.That(updatedToken.Id, Is.EqualTo(token.Id));
    }

    [Test]
    public async Task ShouldTokenizeBasic()
    {
        var client = GetPrivateClient();
        var response = await client.Tokens.TokenizeAsync(new
        {
            first_name = "John",
            last_name = "Doe",
        });
        AssertIsGuid(response.GetJsonElementValue<string>("first_name"));
        AssertIsGuid(response.GetJsonElementValue<string>("last_name"));
    }

    [Test]
    public async Task ShouldTokenizeToken()
    {
        var client = GetPrivateClient();
        var response = await client.Tokens.TokenizeAsync(new
        {
            type = "token",
            data = "Sensitive Value",
            metadata = new {
                nonSensitive = "Non-Sensitive Value"
            },
            search_indexes = new []
            {
                "{{ data }}"
            },
            fingerprint_expression = "{{ data }}"
        });
        AssertIsGuid(response.GetJsonElementValue<string>("id"));
    }

    [Test]
    public async Task ShouldTokenizeCard()
    {
        var client = GetPrivateClient();
        var response = await client.Tokens.TokenizeAsync(new
        {
            type = "card",
            data = new
            {
                number = "4242424242424242",
                expiration_month = 12,
                expiration_year = 2025,
                cvc = "123",
            },
            metadata = new
            {
                nonSensitiveField = "Non-Sensitive Value",
            }
        });
        AssertIsGuid(response.GetJsonElementValue<string>("id"));
    }

    [Test]
    public async Task ShouldTokenizeArray()
    {
        var client = GetPrivateClient();
        var response = await client.Tokens.TokenizeAsync(new List<object>
        {
            "John",
            "Doe",
            new {
                type = "card",
                data = new
                {
                    number = "4242424242424242",
                    expiration_month = 12,
                    expiration_year = 2025,
                    cvc = "123",
                },
                metadata = new
                {
                    nonSensitiveField = "Non-Sensitive Value",
                }
            },
            new
            {
                type = "token",
                data = "Sensitive Value"
            },
        });
        Assert.That(response, Is.TypeOf<JsonElement>());
        var responseJson = (JsonElement)response;
        AssertIsGuid(responseJson[0].GetString());
        AssertIsGuid(responseJson[1].GetString());
        AssertIsGuid(responseJson[2].GetJsonElementValue<string>("id"));
        AssertIsGuid(responseJson[3].GetJsonElementValue<string>("id"));
    }

    [Test]
    public async Task ShouldTokenizeComposite()
    {
        var client = GetPrivateClient();
        var response = await client.Tokens.TokenizeAsync(new
        {
            first_name = "John",
            last_name = "Doe",
            primary_card = new
            {
                type = "card",
                data = new {
                    number = "4242424242424242",
                    expiration_month = 12,
                    expiration_year = 2025,
                    cvc = "123"
                }
            },
            sensitive_tags = new object[]
            {
                "preferred",
                new
                {
                    type = "token",
                    data = "vip"
                }
            }
        });
        AssertIsGuid(response.GetJsonElementValue<string>("first_name"));
        AssertIsGuid(response.GetJsonElementValue<string>("last_name"));
        AssertIsGuid(response.GetJsonElementValue<object>("primary_card")
            .GetJsonElementValue<string>("id"));
        var senstiveTagList = response.GetJsonElementValue<JsonElement>("sensitive_tags");
        AssertIsGuid(senstiveTagList[0].GetString());
        AssertIsGuid(senstiveTagList[1].GetJsonElementValue<string>("id"));
    }

    [Test]
    public async Task ShouldDetokenizeSingle()
    {
        var client = GetPrivateClient();
        var cardNumber = "4242424242424242";
        var tokenId = await CreateToken(client, cardNumber);
        var actual = await client.Tokens.DetokenizeAsync(new
        {
            card_number = "{{ "+tokenId+" | json: '$.number' }}"
        });
        Assert.That(actual.GetJsonElementValue<string>("card_number"), Is.EqualTo(cardNumber));
    }

    [Test]
    public async Task ShouldDetokenizeArray()
    {
        var client = GetPrivateClient();
        var tokenId1 = await CreateToken(client, "4242424242424242");
        var tokenId2 = await CreateToken(client, "4111111111111111");
        var actual = await client.Tokens.DetokenizeAsync(new
        {
            tokens = new []
            {
                $"{{{{ {tokenId1} }}}}",
                $"{{{{ {tokenId2} }}}}"
            }
        });
        var tokensResponseJsonList = actual.GetJsonElementValue<JsonElement>("tokens");
        Assert.That(tokensResponseJsonList[0].GetJsonElementValue<string>("number"), Is.EqualTo("4242424242424242"));
        Assert.That(tokensResponseJsonList[1].GetJsonElementValue<string>("number"), Is.EqualTo("4111111111111111"));
    }

    [Test]
    public async Task ShouldCallBankAccountVerify()
    {
        var client = GetPrivateClient();
        var token = await client.Tokens.CreateAsync(new CreateTokenRequest
        {
            Type = "bank",
            Data = new
            {
                routing_number = "021000021",
                account_number = "00001"
            }
        });
        var actual = await client.Enrichments.BankAccountVerifyAsync(new BankVerificationRequest
        {
            TokenId = token.Id!,
        });
        Assert.That(actual.Status, Is.EqualTo("enabled"));
    }

    [Test]
    public async Task ShouldCallTokenIntents()
    {
        var client = GetPrivateClient();
        var tokenIntent = await client.TokenIntents.CreateAsync(new CreateTokenIntentRequest
        {
            Type = "card",
            Data = new
            {
                number = "4242424242424242",
                expiration_month = 12,
                expiration_year = 2025,
                cvc = "123",
            }
        });
        AssertIsGuid(tokenIntent.Id);
    }

    [Test]
    public async Task ShouldSupportWebhookLifecycle()
    {
        var client = GetManagementClient();

        var url = "https://echo.flock-dev.com/" + Guid.NewGuid();
        var webhookId = await CreateWebhook(client, url);
        await GetAndAssertWebhookUrl(client, webhookId, url);

        Thread.Sleep(TimeSpan.FromSeconds(2)); // Required to avoid error `The webhook subscription is undergoing another concurrent operation. Please wait a few seconds, then try again.`

        var updateUrl = await UpdateWebhook(client, webhookId);
        await GetAndAssertWebhookUrl(client, webhookId, updateUrl);

        Thread.Sleep(TimeSpan.FromSeconds(2)); // Required to avoid error `The webhook subscription is undergoing another concurrent operation. Please wait a few seconds, then try again.`

        await client.Webhooks.DeleteAsync(webhookId);
    }

    [Test]
    public async Task ShouldSupportGooglePay()
    {
        var client = GetPrivateTestTenantClient();

        var gpayToken =
            JsonConvert.DeserializeObject<GooglePayMethodToken>("{\"signature\":\"MEQCIBnz8wKrUi3qrLSn6KSrTcNIo6YcOzrfre7X49S27MrKAiBMF70q7EHe0Bw8uva77pclggSiPMRTFRFl7TZILyACOQ\\u003d\\u003d\",\"intermediateSigningKey\":{\"signedKey\":\"{\\\"keyValue\\\":\\\"MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEnK9rrDl5FJalSwcoZD3qB5EYcA/sYVTH2Nbh6y/EZArFvvBRQA1eI3BIv1iZeCkBLd/A2nU1ve7xENoPOfp7+Q\\\\u003d\\\\u003d\\\",\\\"keyExpiration\\\":\\\"1737724267469\\\"}\",\"signatures\":[\"MEQCIHugFzQtVBVNizwkMhG/POcZAmRRXyeiZpt3aFwBzt5cAiBSOY4pfT4tQGWzZjkldbYkpBwWGpSasxRmlt7XPNOaLQ\\u003d\\u003d\"]},\"protocolVersion\":\"ECv2\",\"signedMessage\":\"{\\\"encryptedMessage\\\":\\\"XURDnvPAIhAKT9rARBV9RT0/yVTesT/w0UniXCJflwu2TkE54UnP7ZmWBo0gKjTJIU3j8D1Rntw2Ywr2UDLbZor+UoeZltzZOAv6iAR4MfvCLSzlh3HcjechwqZM8oxSF2iZoD2XrNqOgaYbOY1EaYoLx1JpftZDuTqSDLYa+szsoPjAUgzBO5TJZTDIa3zDNAdK3UtAPwutL1M4pTyuFhUKOC12J3RzZdaGFANbKSc8vdfqnR1hqsvsEt1sWPf2O3yty91klSA7FDckvwlKfRoNyQMDhaDkEvYUi75uxcjCRHE0Jjbj61bZriSTXiG2KWNF2OKpz7l61kgPJxCpK7A7TV3P4pBLwW7DYbRusO6FupLehxOZl9nBpVfApytCZGjaSXT7QfPpxdBv8j2VfKsodOf/dwv2Thrra9a6ZzFWsUz4l7Jbr4MCBLhXH4lSuxKrlA2Rf/CVPTgz8b88cYpEDZyqLJxDstwy74/Nl7Mjc4V7thzmdskAeYSuZXKXyyeo3BHqkguRkeagEwuHiZoem2V4W2qWOF8hYn14KY3cXXNcVA\\\\u003d\\\\u003d\\\",\\\"ephemeralPublicKey\\\":\\\"BHBDKlM3tik4o9leEkHu+875bHbORaCK7dDeXFCRmv4bzWJw/4bsvtBtaBH3SW5JXkE/6pkRYAtjFzQmHMRQYvc\\\\u003d\\\",\\\"tag\\\":\\\"Hle3Oafx5sfUc3U3sCQgV0tRPhCAvPlVLYiqvbPyTYY\\\\u003d\\\"}\"}");

        try
        {
            await client.GooglePay.CreateAsync(new GooglePayCreateRequest
            {
                GooglePaymentData = gpayToken
            });
            Assert.Fail("Should have raised an exception");
        }
        catch (UnprocessableEntityError e)
        {
            Assert.That(e.Body.Detail.Contains("Failed to decrypt Google payment request"));
        }
    }

    [Test]
    public async Task ShouldSupportClientEncryptionKeyLifecycle()
    {
        var client = GetManagementClient();

        var key = await client.Keys.CreateAsync(new ClientEncryptionKeyRequest());
        AssertIsGuid(key.KeyId);
        Assert.That(key.PublicKeyPem, Is.Not.Null);

        var retrievedKey = await client.Keys.GetAsync(key.KeyId!);
        Assert.That(retrievedKey.KeyId, Is.EqualTo(key.KeyId));
        Assert.That(retrievedKey.ExpiresAt, Is.Not.Null);

        await client.Keys.DeleteAsync(key.KeyId!);

        try
        {
            await client.Keys.GetAsync(key.KeyId!);
            Assert.Fail("Should have raised a 404 for key not found");
        }
        catch (Exception e)
        {
            Assert.That(e, Is.TypeOf<NotFoundError>());
        }
    }

    [Test]
    public async Task ShouldSupportDocumentsLifecycle()
    {
        var client = GetPrivateClient();

        // Upload
        var originalContent = "Hello World";
        var originalMetadata = new Dictionary<string, string?>
        {
            ["attribute 1"] = "value 1",
        };
        var uploaded = await client.Documents.UploadAsync(new DocumentsUploadRequest
        {
            Document = new FileParameter
            {
                Stream = new MemoryStream(Encoding.UTF8.GetBytes(originalContent)),
                FileName = "hello.txt",
                ContentType = "text/plain"
            },
            Request = new CreateDocumentRequest
            {
                Metadata = originalMetadata
            }
        });

        // GET info
        var retrieved = await client.Documents.GetAsync(uploaded.Id!);
        Assert.That(retrieved.ContentType, Is.EqualTo("text/plain"));
        Assert.That(retrieved.Metadata, Is.EqualTo(originalMetadata));

        // GET data
        var data = await client.Documents.Data.GetAsync(uploaded.Id);
        var content = await new StreamReader(data).ReadToEndAsync();
        Assert.That(content, Is.EqualTo(originalContent));

        // DELETE
        await client.Documents.DeleteAsync(uploaded.Id!);
        try
        {
            await client.Documents.GetAsync(uploaded.Id!);
            Assert.Fail("Should have raised a 404 for key not found");
        } catch (Exception e)
        {
            Assert.That(e, Is.TypeOf<NotFoundError>());
        }
    }

    private static async Task<string> UpdateWebhook(BasisTheory client, string webhookId)
    {
        var updateUrl = "https://echo.flock-dev.com/" + Guid.NewGuid();
        await client.Webhooks.UpdateAsync(webhookId,
            new UpdateWebhookRequest
            {
                Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
                Url = updateUrl,
                Events = ["token.created", "token.updated"]
            });
        return updateUrl;
    }

    private static async Task GetAndAssertWebhookUrl(BasisTheory client, string webhookId, string url)
    {
        var w = await client.Webhooks.GetAsync(webhookId);
        Assert.That(w.Url, Is.EqualTo(url));
    }

    private static async Task<string> CreateWebhook(BasisTheory client, string url)
    {
        var webhook = await client.Webhooks.CreateAsync(new CreateWebhookRequest
        {
            Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
            Url = url,
            Events = ["token.created"]
        });
        var webhookId = webhook.Id;
        return webhookId;
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
            new
            {
                args
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

    private static async Task UpdateToken(BasisTheory client, string? tokenId, string cardNumber)
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

    private static async Task<string?> CreateToken(BasisTheory client, string cardNumber, IdempotentRequestOptions? options = null)
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
        }, options);
        var tokenId = token.Id;
        return tokenId;
    }

    private static BasisTheory GetPrivateClient()
    {
        return new BasisTheory(Environment.GetEnvironmentVariable("BT_PVT_API_KEY"),
            clientOptions: new ClientOptions
            {
                BaseUrl = Environment.GetEnvironmentVariable("BT_API_URL")!,
            });
    }

    private static BasisTheory GetPrivateTestTenantClient()
    {
        return new BasisTheory(Environment.GetEnvironmentVariable("BT_PVT_TEST_API_KEY"),
            clientOptions: new ClientOptions
            {
                BaseUrl = Environment.GetEnvironmentVariable("BT_API_URL")!,
            });
    }

    private static BasisTheory GetManagementClient()
    {
        return new BasisTheory(apiKey: Environment.GetEnvironmentVariable("BT_MGT_API_KEY"),
            clientOptions: new ClientOptions
            {
                BaseUrl = Environment.GetEnvironmentVariable("BT_API_URL")!,
            });
    }

    private static void AssertIsGuid(string? expected)
    {
        Assert.That(Guid.TryParse(expected, out Guid _), Is.True);
    }

    private static async Task<string?> CreateApplication(BasisTheory managementClient)
    {
        var application = await managementClient.Applications.CreateAsync(new CreateApplicationRequest
        {
            Name = "(Deletable) dotnet-sdk-" + Guid.NewGuid(),
            Type = "private",
            Permissions = ["token:use"]
        });
        var applicationId = application.Id;
        return applicationId;
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
                JsonValueKind.Object => (T)(object)property,
                JsonValueKind.Array => (T)(object)property,
                _ => defaultValue
            };
        }
        return defaultValue;
    }
}
