using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AccountUpdaterJobStatusSerializer))]
public enum AccountUpdaterJobStatus
{
    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "processing")]
    Processing,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "failed")]
    Failed,
}

internal class AccountUpdaterJobStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AccountUpdaterJobStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AccountUpdaterJobStatus
    > _stringToEnum = new()
    {
        { "pending", AccountUpdaterJobStatus.Pending },
        { "processing", AccountUpdaterJobStatus.Processing },
        { "completed", AccountUpdaterJobStatus.Completed },
        { "failed", AccountUpdaterJobStatus.Failed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AccountUpdaterJobStatus,
        string
    > _enumToString = new()
    {
        { AccountUpdaterJobStatus.Pending, "pending" },
        { AccountUpdaterJobStatus.Processing, "processing" },
        { AccountUpdaterJobStatus.Completed, "completed" },
        { AccountUpdaterJobStatus.Failed, "failed" },
    };

    public override AccountUpdaterJobStatus Read(
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
        AccountUpdaterJobStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AccountUpdaterJobStatus ReadAsPropertyName(
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
        AccountUpdaterJobStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
