using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(PaymentMethodStatusSerializer))]
public enum PaymentMethodStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deleted")]
    Deleted,
}

internal class PaymentMethodStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentMethodStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentMethodStatus
    > _stringToEnum = new()
    {
        { "active", PaymentMethodStatus.Active },
        { "deleted", PaymentMethodStatus.Deleted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentMethodStatus,
        string
    > _enumToString = new()
    {
        { PaymentMethodStatus.Active, "active" },
        { PaymentMethodStatus.Deleted, "deleted" },
    };

    public override PaymentMethodStatus Read(
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
        PaymentMethodStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentMethodStatus ReadAsPropertyName(
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
        PaymentMethodStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
