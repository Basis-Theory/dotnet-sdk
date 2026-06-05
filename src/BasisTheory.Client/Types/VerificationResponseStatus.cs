using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerificationResponseStatusSerializer))]
public enum VerificationResponseStatus
{
    [EnumMember(Value = "approved")]
    Approved,

    [EnumMember(Value = "challenge")]
    Challenge,

    [EnumMember(Value = "otp_sent")]
    OtpSent,

    [EnumMember(Value = "device_bound")]
    DeviceBound,

    [EnumMember(Value = "passkey_required")]
    PasskeyRequired,

    [EnumMember(Value = "redirect_required")]
    RedirectRequired,

    [EnumMember(Value = "verified")]
    Verified,
}

internal class VerificationResponseStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerificationResponseStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerificationResponseStatus
    > _stringToEnum = new()
    {
        { "approved", VerificationResponseStatus.Approved },
        { "challenge", VerificationResponseStatus.Challenge },
        { "otp_sent", VerificationResponseStatus.OtpSent },
        { "device_bound", VerificationResponseStatus.DeviceBound },
        { "passkey_required", VerificationResponseStatus.PasskeyRequired },
        { "redirect_required", VerificationResponseStatus.RedirectRequired },
        { "verified", VerificationResponseStatus.Verified },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerificationResponseStatus,
        string
    > _enumToString = new()
    {
        { VerificationResponseStatus.Approved, "approved" },
        { VerificationResponseStatus.Challenge, "challenge" },
        { VerificationResponseStatus.OtpSent, "otp_sent" },
        { VerificationResponseStatus.DeviceBound, "device_bound" },
        { VerificationResponseStatus.PasskeyRequired, "passkey_required" },
        { VerificationResponseStatus.RedirectRequired, "redirect_required" },
        { VerificationResponseStatus.Verified, "verified" },
    };

    public override VerificationResponseStatus Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        VerificationResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerificationResponseStatus ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        VerificationResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
