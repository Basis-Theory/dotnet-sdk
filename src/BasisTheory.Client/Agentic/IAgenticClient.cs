namespace BasisTheory.Client.Agentic;

public partial interface IAgenticClient
{
    public IEnrollmentsClient Enrollments { get; }
    public IAgentsClient Agents { get; }
    public IPaymentMethodsClient PaymentMethods { get; }
    public IPaymentCredentialsClient PaymentCredentials { get; }
    public IAllowancesClient Allowances { get; }
}
