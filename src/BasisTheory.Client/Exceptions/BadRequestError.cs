namespace BasisTheory.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class BadRequestError(
    object body,
    global::BasisTheory.Client.RawResponse? rawResponse = null
) : BasisTheoryApiException("BadRequestError", 400, body, rawResponse: rawResponse);
