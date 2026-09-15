namespace BasisTheory.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InternalServerError(
    object body,
    global::BasisTheory.Client.RawResponse? rawResponse = null
) : BasisTheoryApiException("InternalServerError", 500, body, rawResponse: rawResponse);
