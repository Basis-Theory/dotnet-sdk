using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(PaymentMethodInstrumentTypeSerializer))]
public enum PaymentMethodInstrumentType
{
    [EnumMember(Value = "card")]
    Card,

    [EnumMember(Value = "bank_account")]
    BankAccount,

    [EnumMember(Value = "other")]
    Other,
}

internal class PaymentMethodInstrumentTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentMethodInstrumentType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentMethodInstrumentType
    > _stringToEnum = new()
    {
        { "card", PaymentMethodInstrumentType.Card },
        { "bank_account", PaymentMethodInstrumentType.BankAccount },
        { "other", PaymentMethodInstrumentType.Other },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentMethodInstrumentType,
        string
    > _enumToString = new()
    {
        { PaymentMethodInstrumentType.Card, "card" },
        { PaymentMethodInstrumentType.BankAccount, "bank_account" },
        { PaymentMethodInstrumentType.Other, "other" },
    };

    public override PaymentMethodInstrumentType Read(
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
        PaymentMethodInstrumentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentMethodInstrumentType ReadAsPropertyName(
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
        PaymentMethodInstrumentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
