using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(InstructionCredentialTypeSerializer))]
public enum InstructionCredentialType
{
    [EnumMember(Value = "card")]
    Card,

    [EnumMember(Value = "spt")]
    Spt,

    [EnumMember(Value = "mpp")]
    Mpp,
}

internal class InstructionCredentialTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InstructionCredentialType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InstructionCredentialType
    > _stringToEnum = new()
    {
        { "card", InstructionCredentialType.Card },
        { "spt", InstructionCredentialType.Spt },
        { "mpp", InstructionCredentialType.Mpp },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InstructionCredentialType,
        string
    > _enumToString = new()
    {
        { InstructionCredentialType.Card, "card" },
        { InstructionCredentialType.Spt, "spt" },
        { InstructionCredentialType.Mpp, "mpp" },
    };

    public override InstructionCredentialType Read(
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
        InstructionCredentialType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InstructionCredentialType ReadAsPropertyName(
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
        InstructionCredentialType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
