using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

public partial class AgenticClient : IAgenticClient
{
    private readonly RawClient _client;

    internal AgenticClient(RawClient client)
    {
        _client = client;
        Enrollments = new EnrollmentsClient(_client);
        Agents = new AgentsClient(_client);
        PaymentMethods = new PaymentMethodsClient(_client);
        PaymentCredentials = new PaymentCredentialsClient(_client);
        Allowances = new AllowancesClient(_client);
    }

    public IEnrollmentsClient Enrollments { get; }

    public IAgentsClient Agents { get; }

    public IPaymentMethodsClient PaymentMethods { get; }

    public IPaymentCredentialsClient PaymentCredentials { get; }

    public IAllowancesClient Allowances { get; }
}
