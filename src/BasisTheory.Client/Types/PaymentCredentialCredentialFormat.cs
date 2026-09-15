using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(PaymentCredentialCredentialFormatSerializer))]
public enum PaymentCredentialCredentialFormat
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

internal class PaymentCredentialCredentialFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentCredentialCredentialFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentCredentialCredentialFormat
    > _stringToEnum = new()
    {
        { "card", PaymentCredentialCredentialFormat.Card },
        { "network-token", PaymentCredentialCredentialFormat.NetworkToken },
        { "identifier", PaymentCredentialCredentialFormat.Identifier },
        { "mpp", PaymentCredentialCredentialFormat.Mpp },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentCredentialCredentialFormat,
        string
    > _enumToString = new()
    {
        { PaymentCredentialCredentialFormat.Card, "card" },
        { PaymentCredentialCredentialFormat.NetworkToken, "network-token" },
        { PaymentCredentialCredentialFormat.Identifier, "identifier" },
        { PaymentCredentialCredentialFormat.Mpp, "mpp" },
    };

    public override PaymentCredentialCredentialFormat Read(
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
        PaymentCredentialCredentialFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentCredentialCredentialFormat ReadAsPropertyName(
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
        PaymentCredentialCredentialFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
