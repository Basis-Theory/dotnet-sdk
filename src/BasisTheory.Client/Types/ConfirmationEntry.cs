using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record ConfirmationEntry
{
    [JsonPropertyName("transaction_reference_id")]
    public string? TransactionReferenceId { get; set; }

    [JsonPropertyName("transaction_status")]
    public required TransactionStatus TransactionStatus { get; set; }

    [JsonPropertyName("transaction_type")]
    public required TransactionType TransactionType { get; set; }

    [JsonPropertyName("transaction_timestamp")]
    public DateTime? TransactionTimestamp { get; set; }

    [JsonPropertyName("mandates_completed")]
    public bool? MandatesCompleted { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
