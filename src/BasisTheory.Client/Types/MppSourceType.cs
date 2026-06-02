using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(MppSourceTypeSerializer))]
public enum MppSourceType
{
    [EnumMember(Value = "token")]
    Token,

    [EnumMember(Value = "network_token")]
    NetworkToken,

    [EnumMember(Value = "apple_pay")]
    ApplePay,

    [EnumMember(Value = "google_pay")]
    GooglePay,

    [EnumMember(Value = "visa_intelligent_commerce")]
    VisaIntelligentCommerce,
}

internal class MppSourceTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MppSourceType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MppSourceType
    > _stringToEnum = new()
    {
        { "token", MppSourceType.Token },
        { "network_token", MppSourceType.NetworkToken },
        { "apple_pay", MppSourceType.ApplePay },
        { "google_pay", MppSourceType.GooglePay },
        { "visa_intelligent_commerce", MppSourceType.VisaIntelligentCommerce },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MppSourceType,
        string
    > _enumToString = new()
    {
        { MppSourceType.Token, "token" },
        { MppSourceType.NetworkToken, "network_token" },
        { MppSourceType.ApplePay, "apple_pay" },
        { MppSourceType.GooglePay, "google_pay" },
        { MppSourceType.VisaIntelligentCommerce, "visa_intelligent_commerce" },
    };

    public override MppSourceType Read(
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
        MppSourceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MppSourceType ReadAsPropertyName(
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
        MppSourceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
