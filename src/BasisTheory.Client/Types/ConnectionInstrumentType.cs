using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(ConnectionInstrumentTypeSerializer))]
public enum ConnectionInstrumentType
{
    [EnumMember(Value = "card")]
    Card,

    [EnumMember(Value = "bank_account")]
    BankAccount,

    [EnumMember(Value = "stablecoin_wallet")]
    StablecoinWallet,

    [EnumMember(Value = "bnpl_account")]
    BnplAccount,

    [EnumMember(Value = "other")]
    Other,
}

internal class ConnectionInstrumentTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ConnectionInstrumentType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ConnectionInstrumentType
    > _stringToEnum = new()
    {
        { "card", ConnectionInstrumentType.Card },
        { "bank_account", ConnectionInstrumentType.BankAccount },
        { "stablecoin_wallet", ConnectionInstrumentType.StablecoinWallet },
        { "bnpl_account", ConnectionInstrumentType.BnplAccount },
        { "other", ConnectionInstrumentType.Other },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ConnectionInstrumentType,
        string
    > _enumToString = new()
    {
        { ConnectionInstrumentType.Card, "card" },
        { ConnectionInstrumentType.BankAccount, "bank_account" },
        { ConnectionInstrumentType.StablecoinWallet, "stablecoin_wallet" },
        { ConnectionInstrumentType.BnplAccount, "bnpl_account" },
        { ConnectionInstrumentType.Other, "other" },
    };

    public override ConnectionInstrumentType Read(
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
        ConnectionInstrumentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ConnectionInstrumentType ReadAsPropertyName(
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
        ConnectionInstrumentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
