using global::BasisTheory.Client.Webhooks;

namespace BasisTheory.Client;

public partial interface IWebhooksClient
{
    public IEventsClient Events { get; }

    /// <summary>
    /// Simple endpoint that can be utilized to verify the application is running
    /// </summary>
    Task PingAsync(RequestOptions? options = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the webhook
    /// </summary>
    WithRawResponseTask<Webhook> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a new webhook
    /// </summary>
    WithRawResponseTask<Webhook> UpdateAsync(
        string id,
        UpdateWebhookRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a new webhook
    /// </summary>
    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the configured webhooks
    /// </summary>
    WithRawResponseTask<WebhookList> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new webhook
    /// </summary>
    WithRawResponseTask<Webhook> CreateAsync(
        CreateWebhookRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
