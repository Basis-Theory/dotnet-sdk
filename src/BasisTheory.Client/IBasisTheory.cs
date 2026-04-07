using global::BasisTheory.Client.AccountUpdater;
using global::BasisTheory.Client.Tenants;
using global::BasisTheory.Client.Threeds;

namespace BasisTheory.Client;

public partial interface IBasisTheory
{
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
}
