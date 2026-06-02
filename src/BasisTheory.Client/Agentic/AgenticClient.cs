using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

public partial class AgenticClient : IAgenticClient
{
    private readonly RawClient _client;

    internal AgenticClient(RawClient client)
    {
        _client = client;
        Agents = new AgentsClient(_client);
        Enrollments = new EnrollmentsClient(_client);
    }

    public IAgentsClient Agents { get; }

    public IEnrollmentsClient Enrollments { get; }
}
