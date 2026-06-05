using global::BasisTheory.Client;
using global::BasisTheory.Client.Agentic.Agents;

namespace BasisTheory.Client.Agentic;

public partial interface IAgentsClient
{
    public IInstructionsClient Instructions { get; }
    WithRawResponseTask<Agent> CreateAsync(
        CreateAgentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Agent> GetAsync(
        string agentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string agentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Agent> UpdateAsync(
        string agentId,
        UpdateAgentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
