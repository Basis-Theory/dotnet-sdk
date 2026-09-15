using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(PaymentMethodRailProviderSerializer))]
public enum PaymentMethodRailProvider
{
    [EnumMember(Value = "vic")]
    Vic,

    [EnumMember(Value = "agentpay")]
    Agentpay,
}

internal class PaymentMethodRailProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentMethodRailProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentMethodRailProvider
    > _stringToEnum = new()
    {
        { "vic", PaymentMethodRailProvider.Vic },
        { "agentpay", PaymentMethodRailProvider.Agentpay },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentMethodRailProvider,
        string
    > _enumToString = new()
    {
        { PaymentMethodRailProvider.Vic, "vic" },
        { PaymentMethodRailProvider.Agentpay, "agentpay" },
    };

    public override PaymentMethodRailProvider Read(
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
        PaymentMethodRailProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentMethodRailProvider ReadAsPropertyName(
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
        PaymentMethodRailProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
