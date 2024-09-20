namespace BasisTheory.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class UnauthorizedError(ProblemDetails body)
    : BasisTheoryApiException("UnauthorizedError", 401, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ProblemDetails Body => body;
}
