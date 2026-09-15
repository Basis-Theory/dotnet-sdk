using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(ConnectionStatusDetailsActorSerializer))]
public enum ConnectionStatusDetailsActor
{
    [EnumMember(Value = "consumer")]
    Consumer,

    [EnumMember(Value = "tenant_admin")]
    TenantAdmin,

    [EnumMember(Value = "basis_theory")]
    BasisTheory,
}

internal class ConnectionStatusDetailsActorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ConnectionStatusDetailsActor>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ConnectionStatusDetailsActor
    > _stringToEnum = new()
    {
        { "consumer", ConnectionStatusDetailsActor.Consumer },
        { "tenant_admin", ConnectionStatusDetailsActor.TenantAdmin },
        { "basis_theory", ConnectionStatusDetailsActor.BasisTheory },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ConnectionStatusDetailsActor,
        string
    > _enumToString = new()
    {
        { ConnectionStatusDetailsActor.Consumer, "consumer" },
        { ConnectionStatusDetailsActor.TenantAdmin, "tenant_admin" },
        { ConnectionStatusDetailsActor.BasisTheory, "basis_theory" },
    };

    public override ConnectionStatusDetailsActor Read(
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
        ConnectionStatusDetailsActor value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ConnectionStatusDetailsActor ReadAsPropertyName(
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
        ConnectionStatusDetailsActor value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
