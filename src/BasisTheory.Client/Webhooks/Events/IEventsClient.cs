using global::BasisTheory.Client;

namespace BasisTheory.Client.Webhooks;

public partial interface IEventsClient
{
    /// <summary>
    /// Return a list of available event types
    /// </summary>
    WithRawResponseTask<IEnumerable<string>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
