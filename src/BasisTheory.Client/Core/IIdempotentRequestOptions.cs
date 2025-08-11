namespace BasisTheory.Client.Core;

internal interface IIdempotentRequestOptions : IRequestOptions
{
    public string? IdempotencyKey { get;
#if NET5_0_OR_GREATER
        init;
#else
        set;
#endif
    }
    internal Headers GetIdempotencyHeaders();
}
