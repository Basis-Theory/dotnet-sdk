using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnrollmentStatusSerializer))]
public enum EnrollmentStatus
{
    [EnumMember(Value = "pending_verification")]
    PendingVerification,

    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "suspended")]
    Suspended,

    [EnumMember(Value = "deleted")]
    Deleted,

    [EnumMember(Value = "failed")]
    Failed,
}

internal class EnrollmentStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EnrollmentStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EnrollmentStatus
    > _stringToEnum = new()
    {
        { "pending_verification", EnrollmentStatus.PendingVerification },
        { "active", EnrollmentStatus.Active },
        { "suspended", EnrollmentStatus.Suspended },
        { "deleted", EnrollmentStatus.Deleted },
        { "failed", EnrollmentStatus.Failed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EnrollmentStatus,
        string
    > _enumToString = new()
    {
        { EnrollmentStatus.PendingVerification, "pending_verification" },
        { EnrollmentStatus.Active, "active" },
        { EnrollmentStatus.Suspended, "suspended" },
        { EnrollmentStatus.Deleted, "deleted" },
        { EnrollmentStatus.Failed, "failed" },
    };

    public override EnrollmentStatus Read(
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
        EnrollmentStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EnrollmentStatus ReadAsPropertyName(
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
        EnrollmentStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
