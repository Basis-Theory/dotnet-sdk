namespace BasisTheory.Client.Core;

internal interface IIdempotentRequestOptions : IRequestOptions
{
    public string? IdempotencyKey { get; init; }
    internal Headers GetIdempotencyHeaders();
}
