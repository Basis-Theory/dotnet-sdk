using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Agents;

[Serializable]
public record CreateInstructionRequest
{
    [JsonPropertyName("enrollment_id")]
    public required string EnrollmentId { get; set; }

    [JsonPropertyName("amount")]
    public required Amount Amount { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("expires_at")]
    public required DateTime ExpiresAt { get; set; }

    [JsonPropertyName("assurance_data")]
    public object? AssuranceData { get; set; }

    [JsonPropertyName("recurring")]
    public Recurring? Recurring { get; set; }

    [JsonPropertyName("instance_details")]
    public InstanceDetails? InstanceDetails { get; set; }

    /// <summary>
    /// Stripe network business profile identifier (`profile_...`) of the seller allowed to use the
    /// shared payment token. Maps to Stripe's `seller_details[network_business_profile]`.
    /// Only valid for `spt` (Stripe) enrollments; required unless an MPP challenge with Stripe
    /// network details is provided.
    /// </summary>
    [JsonPropertyName("network_business_profile")]
    public string? NetworkBusinessProfile { get; set; }

    /// <summary>
    /// MPP mode — provide the merchant's MPP challenge to receive an MPP credential from the
    /// credentials endpoint instead of a raw shared payment token ID. The challenge must carry
    /// Stripe values (`method: stripe`). Only valid for `spt` (Stripe) enrollments.
    /// </summary>
    [JsonPropertyName("mpp")]
    public CreateInstructionRequestMpp? Mpp { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
