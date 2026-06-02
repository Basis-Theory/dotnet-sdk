namespace BasisTheory.Client;

public partial interface IEnrichmentsClient
{
    WithRawResponseTask<BankVerificationResponse> BankAccountVerifyAsync(
        BankVerificationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CardDetailsResponse> GetcarddetailsAsync(
        EnrichmentsGetCardDetailsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
