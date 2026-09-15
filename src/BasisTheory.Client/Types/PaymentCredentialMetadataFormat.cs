using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(PaymentCredentialMetadataFormatSerializer))]
public enum PaymentCredentialMetadataFormat
{
    [EnumMember(Value = "card")]
    Card,

    [EnumMember(Value = "network-token")]
    NetworkToken,

    [EnumMember(Value = "identifier")]
    Identifier,

    [EnumMember(Value = "mpp")]
    Mpp,
}

internal class PaymentCredentialMetadataFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentCredentialMetadataFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentCredentialMetadataFormat
    > _stringToEnum = new()
    {
        { "card", PaymentCredentialMetadataFormat.Card },
        { "network-token", PaymentCredentialMetadataFormat.NetworkToken },
        { "identifier", PaymentCredentialMetadataFormat.Identifier },
        { "mpp", PaymentCredentialMetadataFormat.Mpp },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentCredentialMetadataFormat,
        string
    > _enumToString = new()
    {
        { PaymentCredentialMetadataFormat.Card, "card" },
        { PaymentCredentialMetadataFormat.NetworkToken, "network-token" },
        { PaymentCredentialMetadataFormat.Identifier, "identifier" },
        { PaymentCredentialMetadataFormat.Mpp, "mpp" },
    };

    public override PaymentCredentialMetadataFormat Read(
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
        PaymentCredentialMetadataFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentCredentialMetadataFormat ReadAsPropertyName(
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
        PaymentCredentialMetadataFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
