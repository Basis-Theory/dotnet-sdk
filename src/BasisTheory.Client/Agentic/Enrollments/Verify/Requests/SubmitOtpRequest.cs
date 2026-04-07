using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

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
