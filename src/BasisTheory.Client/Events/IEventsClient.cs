using global::BasisTheory.Client.Core;

namespace BasisTheory.Client;

public partial interface IEventsClient
{
    /// <summary>
    /// Requires event:read. Tenant identity comes from trusted API-key authentication. History is limited by log_history_limit (24 hours by default, at most 30 days). Windows reaching outside the visible history are clamped to it rather than rejected. No secondary failover or portal JWT support. SDK callers supply data.&lt;path&gt; filters as literal keys through the SDK's per-request query-parameter options, not as a filters request field.
    /// </summary>
    Task<Pager<Event>> ListAsync(
        EventsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
