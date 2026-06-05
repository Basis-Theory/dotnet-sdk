using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(TransactionStatusSerializer))]
public enum TransactionStatus
{
    [EnumMember(Value = "approved")]
    Approved,

    [EnumMember(Value = "declined")]
    Declined,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "cancelled")]
    Cancelled,
}

internal class TransactionStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransactionStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransactionStatus
    > _stringToEnum = new()
    {
        { "approved", TransactionStatus.Approved },
        { "declined", TransactionStatus.Declined },
        { "pending", TransactionStatus.Pending },
        { "error", TransactionStatus.Error },
        { "cancelled", TransactionStatus.Cancelled },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransactionStatus,
        string
    > _enumToString = new()
    {
        { TransactionStatus.Approved, "approved" },
        { TransactionStatus.Declined, "declined" },
        { TransactionStatus.Pending, "pending" },
        { TransactionStatus.Error, "error" },
        { TransactionStatus.Cancelled, "cancelled" },
    };

    public override TransactionStatus Read(
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
        TransactionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransactionStatus ReadAsPropertyName(
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
        TransactionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
