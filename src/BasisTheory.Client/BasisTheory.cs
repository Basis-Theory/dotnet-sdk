using BasisTheory.Client.Connections;
using BasisTheory.Client.Core;
using BasisTheory.Client.Tenants;
using BasisTheory.Client.Threeds;

#nullable enable

namespace BasisTheory.Client;

public partial class BasisTheory
{
    private RawClient _client;

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
        Tokens = new TokensClient(_client);
        Enrichments = new EnrichmentsClient(_client);
        Logs = new LogsClient(_client);
        Permissions = new PermissionsClient(_client);
        Proxies = new ProxiesClient(_client);
        Reactors = new ReactorsClient(_client);
        Roles = new RolesClient(_client);
        Sessions = new SessionsClient(_client);
        TokenIntents = new TokenIntentsClient(_client);
        Webhooks = new WebhooksClient(_client);
        Connections = new ConnectionsClient(_client);
        Tenants = new TenantsClient(_client);
        Threeds = new ThreedsClient(_client);
    }

    public ApplicationsClient Applications { get; init; }

    public ApplicationKeysClient ApplicationKeys { get; init; }

    public ApplicationTemplatesClient ApplicationTemplates { get; init; }

    public TokensClient Tokens { get; init; }

    public EnrichmentsClient Enrichments { get; init; }

    public LogsClient Logs { get; init; }

    public PermissionsClient Permissions { get; init; }

    public ProxiesClient Proxies { get; init; }

    public ReactorsClient Reactors { get; init; }

    public RolesClient Roles { get; init; }

    public SessionsClient Sessions { get; init; }

    public TokenIntentsClient TokenIntents { get; init; }

    public WebhooksClient Webhooks { get; init; }

    public ConnectionsClient Connections { get; init; }

    public TenantsClient Tenants { get; init; }

    public ThreedsClient Threeds { get; init; }

    private static string GetFromEnvironmentOrThrow(string env, string message)
    {
        return Environment.GetEnvironmentVariable(env) ?? throw new Exception(message);
    }
}
