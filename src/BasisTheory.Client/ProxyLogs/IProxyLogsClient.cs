using global::BasisTheory.Client.Core;

namespace BasisTheory.Client;

public partial interface IProxyLogsClient
{
    /// <summary>
    /// Requires log:read. Returns individual Proxy runtime records, not event envelopes or neighboring records from the same batch. Tenant and history entitlement are checked on every request. Date bounds use occurred_at, inclusive at start and exclusive at end, and are clamped to current entitlement, now, and the 30-day maximum. Results are asynchronously visible. Responses include source (origin) and record_type (record kind); both have exact, case-sensitive string filters, with application/log and platform/lifecycle as the supported pairings. error and attributes are complete display-only objects and cannot be filtered or searched. IDs are stable logical record identities for deduplicating polling overlap. Pagination is bounded; follow next even after a short page. No cross-page uniqueness or snapshot is promised. Query parameters must be single strings; repeated, unknown, or operator parameters are 400. There are at most 36 parameters, values are at most 1,024 characters (cursor: 12,000), and combined filters are limited to 4,096 UTF-8 bytes. Word search trims/collapses whitespace and is limited to 256 normalized characters.
    /// </summary>
    Task<Pager<RuntimeLog>> ListAsync(
        string proxyId,
        ProxyLogsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
