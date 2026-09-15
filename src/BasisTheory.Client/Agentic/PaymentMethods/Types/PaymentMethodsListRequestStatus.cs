using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[JsonConverter(typeof(PaymentMethodsListRequestStatusSerializer))]
public enum PaymentMethodsListRequestStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deleted")]
    Deleted,

    [EnumMember(Value = "all")]
    All,
}

internal class PaymentMethodsListRequestStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentMethodsListRequestStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentMethodsListRequestStatus
    > _stringToEnum = new()
    {
        { "active", PaymentMethodsListRequestStatus.Active },
        { "deleted", PaymentMethodsListRequestStatus.Deleted },
        { "all", PaymentMethodsListRequestStatus.All },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentMethodsListRequestStatus,
        string
    > _enumToString = new()
    {
        { PaymentMethodsListRequestStatus.Active, "active" },
        { PaymentMethodsListRequestStatus.Deleted, "deleted" },
        { PaymentMethodsListRequestStatus.All, "all" },
    };

    public override PaymentMethodsListRequestStatus Read(
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
        PaymentMethodsListRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentMethodsListRequestStatus ReadAsPropertyName(
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
        PaymentMethodsListRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
