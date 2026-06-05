namespace BasisTheory.Client;

public partial interface IEnrichmentsClient
{
    WithRawResponseTask<BankVerificationResponse> BankAccountVerifyAsync(
        BankVerificationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CardDetailsResponse> CardDetailsAsync(
        EnrichmentsCardDetailsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
