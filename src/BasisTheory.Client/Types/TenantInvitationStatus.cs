using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(TenantInvitationStatusSerializer))]
public enum TenantInvitationStatus
{
    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "EXPIRED")]
    Expired,
}

internal class TenantInvitationStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TenantInvitationStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TenantInvitationStatus
    > _stringToEnum = new()
    {
        { "PENDING", TenantInvitationStatus.Pending },
        { "EXPIRED", TenantInvitationStatus.Expired },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TenantInvitationStatus,
        string
    > _enumToString = new()
    {
        { TenantInvitationStatus.Pending, "PENDING" },
        { TenantInvitationStatus.Expired, "EXPIRED" },
    };

    public override TenantInvitationStatus Read(
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
        TenantInvitationStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TenantInvitationStatus ReadAsPropertyName(
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
        TenantInvitationStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
