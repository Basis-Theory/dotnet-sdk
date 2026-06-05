namespace BasisTheory.Client.Agentic;

public partial interface IAgenticClient
{
    public IAgentsClient Agents { get; }
    public IEnrollmentsClient Enrollments { get; }
}
