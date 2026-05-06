using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

public partial class AgenticClient
{
    private RawClient _client;

    internal AgenticClient(RawClient client)
    {
        _client = client;
        Agents = new AgentsClient(_client);
        Enrollments = new EnrollmentsClient(_client);
    }

    public AgentsClient Agents { get; }

    public EnrollmentsClient Enrollments { get; }
}
