namespace BasisTheory.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ForbiddenError(object body, global::BasisTheory.Client.RawResponse? rawResponse = null)
    : BasisTheoryApiException("ForbiddenError", 403, body, rawResponse: rawResponse);
