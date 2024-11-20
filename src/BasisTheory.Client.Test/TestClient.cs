using System.Text.Json;
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
            new ReactRequest
            {
                Args = new
                {
                    foo = "bar"
                }
            }
        );
        Assert.That(reactResponse.Raw!.GetJsonElementValue<string>("foo"), Is.EqualTo("bar"));

        var asyncReactResponse = await client.Reactors.ReactAsyncAsync(
            reactorId,
            new ReactRequestAsync
            {
                Args = new
                {
                    foo = "bar"
                }
            }
        );
        AssertIsGuid(asyncReactResponse.AsyncReactorRequestId);

        await managementClient.Reactors.DeleteAsync(reactorId);
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
    public async Task ShouldSupportAutoPaginationOnListV1()
    {
        var client = GetPrivateClient();
        const int pageSize = 3;
        var tokens = client.Tokens.ListAsync(new TokensListRequest
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
    public async Task ShouldSupportAutoPaginationOnListV2()
    {
        var client = GetPrivateClient();
        const int pageSize = 3;
        var tokens = client.Tokens.ListV2Async(new TokensListV2Request
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
    public async Task ShouldSupportWebhookLifecycle()
    {
        var client = GetManagementClient();

        var url = "https://echo.basistheory.com/" + Guid.NewGuid();
        var webhookId = await CreateWebhook(client, url);
        await GetAndAssertWebhookUrl(client, webhookId, url);

        Thread.Sleep(TimeSpan.FromSeconds(2)); // Required to avoid error `The webhook subscription is undergoing another concurrent operation. Please wait a few seconds, then try again.`

        var updateUrl = await UpdateWebhook(client, webhookId);
        await GetAndAssertWebhookUrl(client, webhookId, updateUrl);

        Thread.Sleep(TimeSpan.FromSeconds(2)); // Required to avoid error `The webhook subscription is undergoing another concurrent operation. Please wait a few seconds, then try again.`

        await client.Webhooks.DeleteAsync(webhookId);
    }

    private static async Task<string> UpdateWebhook(BasisTheory client, string webhookId)
    {
        var updateUrl = "https://echo.basistheory.com/" + Guid.NewGuid();
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