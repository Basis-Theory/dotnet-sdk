namespace BasisTheory.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotFoundError(object body, global::BasisTheory.Client.RawResponse? rawResponse = null)
    : BasisTheoryApiException("NotFoundError", 404, body, rawResponse: rawResponse);
