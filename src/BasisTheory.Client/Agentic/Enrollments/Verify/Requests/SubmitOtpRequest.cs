using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Enrollments;

[Serializable]
public record SubmitOtpRequest
{
    [JsonPropertyName("otp_code")]
    public required string OtpCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
