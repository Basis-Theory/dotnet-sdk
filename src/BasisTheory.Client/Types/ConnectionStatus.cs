using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(ConnectionStatusSerializer))]
public enum ConnectionStatus
{
    [EnumMember(Value = "pending_authorization")]
    PendingAuthorization,

    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "requires_reauthorization")]
    RequiresReauthorization,

    [EnumMember(Value = "inactive")]
    Inactive,

    [EnumMember(Value = "revoked")]
    Revoked,
}

internal class ConnectionStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ConnectionStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ConnectionStatus
    > _stringToEnum = new()
    {
        { "pending_authorization", ConnectionStatus.PendingAuthorization },
        { "active", ConnectionStatus.Active },
        { "requires_reauthorization", ConnectionStatus.RequiresReauthorization },
        { "inactive", ConnectionStatus.Inactive },
        { "revoked", ConnectionStatus.Revoked },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ConnectionStatus,
        string
    > _enumToString = new()
    {
        { ConnectionStatus.PendingAuthorization, "pending_authorization" },
        { ConnectionStatus.Active, "active" },
        { ConnectionStatus.RequiresReauthorization, "requires_reauthorization" },
        { ConnectionStatus.Inactive, "inactive" },
        { ConnectionStatus.Revoked, "revoked" },
    };

    public override ConnectionStatus Read(
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
        ConnectionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ConnectionStatus ReadAsPropertyName(
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
        ConnectionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
