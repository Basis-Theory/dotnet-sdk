using global::BasisTheory.Client;

namespace BasisTheory.Client.Agentic.Agents.Instructions;

public partial interface ICredentialsClient
{
    /// <summary>
    /// Retrieve payment credentials (card number, expiration, CVC) for a purchase instruction.
    /// </summary>
    WithRawResponseTask<Credentials> CreateAsync(
        string agentId,
        string instructionId,
        GetCredentialsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
