using global::BasisTheory.Client;
using global::BasisTheory.Client.Agentic.Agents.Instructions;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Agents;

public partial interface IInstructionsClient
{
    public ICredentialsClient Credentials { get; }
    public global::BasisTheory.Client.Agentic.Agents.Instructions.IVerifyClient Verify { get; }

    /// <summary>
    /// List all purchase instructions for an agent with cursor-based pagination and optional enrollment filter.
    /// </summary>
    Task<Pager<Instruction>> ListAsync(
        string agentId,
        InstructionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new payment instruction for an agent, linked to an enrollment.
    /// </summary>
    WithRawResponseTask<Instruction> CreateAsync(
        string agentId,
        CreateInstructionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Instruction> GetAsync(
        string agentId,
        string instructionId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAsync(
        string agentId,
        string instructionId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Instruction> UpdateAsync(
        string agentId,
        string instructionId,
        UpdateInstructionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
