namespace BasisTheory.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ConflictError(object body, global::BasisTheory.Client.RawResponse? rawResponse = null)
    : BasisTheoryApiException("ConflictError", 409, body, rawResponse: rawResponse);
