namespace BasisTheory.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class UnauthorizedError(
    object body,
    global::BasisTheory.Client.RawResponse? rawResponse = null
) : BasisTheoryApiException("UnauthorizedError", 401, body, rawResponse: rawResponse);
