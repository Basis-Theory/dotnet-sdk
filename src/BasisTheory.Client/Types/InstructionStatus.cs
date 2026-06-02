using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(InstructionStatusSerializer))]
public enum InstructionStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "pending_verification")]
    PendingVerification,

    [EnumMember(Value = "approved")]
    Approved,

    [EnumMember(Value = "cancelled")]
    Cancelled,

    [EnumMember(Value = "expired")]
    Expired,
}

internal class InstructionStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InstructionStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InstructionStatus
    > _stringToEnum = new()
    {
        { "active", InstructionStatus.Active },
        { "pending", InstructionStatus.Pending },
        { "pending_verification", InstructionStatus.PendingVerification },
        { "approved", InstructionStatus.Approved },
        { "cancelled", InstructionStatus.Cancelled },
        { "expired", InstructionStatus.Expired },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InstructionStatus,
        string
    > _enumToString = new()
    {
        { InstructionStatus.Active, "active" },
        { InstructionStatus.Pending, "pending" },
        { InstructionStatus.PendingVerification, "pending_verification" },
        { InstructionStatus.Approved, "approved" },
        { InstructionStatus.Cancelled, "cancelled" },
        { InstructionStatus.Expired, "expired" },
    };

    public override InstructionStatus Read(
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
        InstructionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InstructionStatus ReadAsPropertyName(
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
        InstructionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
