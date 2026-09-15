using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(ConnectionPrincipalTypeSerializer))]
public enum ConnectionPrincipalType
{
    [EnumMember(Value = "consumer")]
    Consumer,

    [EnumMember(Value = "tenant")]
    Tenant,
}

internal class ConnectionPrincipalTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ConnectionPrincipalType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ConnectionPrincipalType
    > _stringToEnum = new()
    {
        { "consumer", ConnectionPrincipalType.Consumer },
        { "tenant", ConnectionPrincipalType.Tenant },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ConnectionPrincipalType,
        string
    > _enumToString = new()
    {
        { ConnectionPrincipalType.Consumer, "consumer" },
        { ConnectionPrincipalType.Tenant, "tenant" },
    };

    public override ConnectionPrincipalType Read(
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
        ConnectionPrincipalType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ConnectionPrincipalType ReadAsPropertyName(
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
        ConnectionPrincipalType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
