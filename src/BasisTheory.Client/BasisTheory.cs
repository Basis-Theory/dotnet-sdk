using global::BasisTheory.Client.AccountUpdater;
using global::BasisTheory.Client.Core;
using global::BasisTheory.Client.Tenants;
using global::BasisTheory.Client.Threeds;

namespace BasisTheory.Client;

public partial class BasisTheory : IBasisTheory
{
    private readonly RawClient _client;

    public BasisTheory(
        string? apiKey = null,
        string? correlationId = null,
        ClientOptions? clientOptions = null
    )
    {
        apiKey ??= GetFromEnvironmentOrThrow(
            "BT-API-KEY",
            "Please pass in apiKey or set the environment variable BT-API-KEY."
        );
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "BasisTheory.Client" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "BasisTheory/0.0.1" },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "BT-API-KEY", apiKey ?? "" },
                { "BT-TRACE-ID", correlationId ?? "" },
            }
        );
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
        Applications = new ApplicationsClient(_client);
        ApplicationKeys = new ApplicationKeysClient(_client);
        ApplicationTemplates = new ApplicationTemplatesClient(_client);
        ApplePay = new ApplePayClient(_client);
        GooglePay = new GooglePayClient(_client);
        Documents = new DocumentsClient(_client);
        Tokens = new TokensClient(_client);
        Enrichments = new EnrichmentsClient(_client);
        Keys = new KeysClient(_client);
        Logs = new LogsClient(_client);
        NetworkTokens = new NetworkTokensClient(_client);
        Permissions = new PermissionsClient(_client);
        Proxies = new ProxiesClient(_client);
        Reactors = new ReactorsClient(_client);
        Roles = new RolesClient(_client);
        Sessions = new SessionsClient(_client);
        TokenIntents = new TokenIntentsClient(_client);
        Webhooks = new WebhooksClient(_client);
        AccountUpdater = new AccountUpdaterClient(_client);
        Tenants = new TenantsClient(_client);
        Threeds = new ThreedsClient(_client);
    }

    public IApplicationsClient Applications { get; }

    public IApplicationKeysClient ApplicationKeys { get; }

    public IApplicationTemplatesClient ApplicationTemplates { get; }

    public IApplePayClient ApplePay { get; }

    public IGooglePayClient GooglePay { get; }

    public IDocumentsClient Documents { get; }

    public ITokensClient Tokens { get; }

    public IEnrichmentsClient Enrichments { get; }

    public IKeysClient Keys { get; }

    public ILogsClient Logs { get; }

    public INetworkTokensClient NetworkTokens { get; }

    public IPermissionsClient Permissions { get; }

    public IProxiesClient Proxies { get; }

    public IReactorsClient Reactors { get; }

    public IRolesClient Roles { get; }

    public ISessionsClient Sessions { get; }

    public ITokenIntentsClient TokenIntents { get; }

    public IWebhooksClient Webhooks { get; }

    public IAccountUpdaterClient AccountUpdater { get; }

    public ITenantsClient Tenants { get; }

    public IThreedsClient Threeds { get; }

    private static string GetFromEnvironmentOrThrow(string env, string message)
    {
        return Environment.GetEnvironmentVariable(env) ?? throw new Exception(message);
    }
}
