using BasisTheory.Client.AccountUpdater;
using BasisTheory.Client.Core;
using BasisTheory.Client.Threeds;

namespace BasisTheory.Client;

public partial class BasisTheory
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
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "BT-API-KEY", apiKey },
                { "BT-TRACE-ID", correlationId },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "BasisTheory.Client" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "BasisTheory/0.0.1" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
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
        Tenants = new TenantsClient(_client);
        Sessions = new SessionsClient(_client);
        TokenIntents = new TokenIntentsClient(_client);
        Webhooks = new WebhooksClient(_client);
        AccountUpdater = new AccountUpdaterClient(_client);
        Threeds = new ThreedsClient(_client);
    }

    public ApplicationsClient Applications { get; }

    public ApplicationKeysClient ApplicationKeys { get; }

    public ApplicationTemplatesClient ApplicationTemplates { get; }

    public ApplePayClient ApplePay { get; }

    public GooglePayClient GooglePay { get; }

    public DocumentsClient Documents { get; }

    public TokensClient Tokens { get; }

    public EnrichmentsClient Enrichments { get; }

    public KeysClient Keys { get; }

    public LogsClient Logs { get; }

    public NetworkTokensClient NetworkTokens { get; }

    public PermissionsClient Permissions { get; }

    public ProxiesClient Proxies { get; }

    public ReactorsClient Reactors { get; }

    public RolesClient Roles { get; }

    public TenantsClient Tenants { get; }

    public SessionsClient Sessions { get; }

    public TokenIntentsClient TokenIntents { get; }

    public WebhooksClient Webhooks { get; }

    public AccountUpdaterClient AccountUpdater { get; }

    public ThreedsClient Threeds { get; }

    private static string GetFromEnvironmentOrThrow(string env, string message)
    {
        return Environment.GetEnvironmentVariable(env) ?? throw new Exception(message);
    }
}
