using global::BasisTheory.Client;

namespace BasisTheory.Client.Agentic.Enrollments;

public partial interface IVerifyClient
{
    /// <summary>
    /// Initiates the cardholder verification flow for a pending enrollment.
    /// </summary>
    WithRawResponseTask<VerificationResponse> StartAsync(
        string enrollmentId,
        StartVerificationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Choose the OTP delivery method (SMS, email, etc.) for enrollment verification.
    /// </summary>
    WithRawResponseTask<VerificationResponse> MethodAsync(
        string enrollmentId,
        SelectMethodRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Submit the one-time password received by the cardholder.
    /// </summary>
    WithRawResponseTask<VerificationResponse> OtpAsync(
        string enrollmentId,
        SubmitOtpRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Complete the verification flow (e.g. after passkey creation). Body is optional — Visa sends empty body, Mastercard sends assurance_data.
    /// </summary>
    WithRawResponseTask<VerificationResponse> CompleteAsync(
        string enrollmentId,
        CompleteVerificationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
