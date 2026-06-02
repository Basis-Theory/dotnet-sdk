using global::BasisTheory.Client;

namespace BasisTheory.Client.Agentic.Agents.Instructions;

public partial interface IVerifyClient
{
    /// <summary>
    /// Initiate cardholder verification for a purchase instruction that requires it.
    /// </summary>
    WithRawResponseTask<VerificationResponse> StartAsync(
        string agentId,
        string instructionId,
        StartVerificationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Submit passkey/FIDO assertion data to complete instruction verification.
    /// </summary>
    WithRawResponseTask<Instruction> PasskeyAsync(
        string agentId,
        string instructionId,
        SubmitPasskeyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
