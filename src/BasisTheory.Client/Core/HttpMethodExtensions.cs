using System.Net.Http;

namespace BasisTheory.Client.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
