using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerifyAllowanceRequestStartRailSerializer))]
public enum VerifyAllowanceRequestStartRail
{
    [EnumMember(Value = "agentic-token")]
    AgenticToken,

    [EnumMember(Value = "spt")]
    Spt,

    [EnumMember(Value = "virtual-card")]
    VirtualCard,
}

internal class VerifyAllowanceRequestStartRailSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerifyAllowanceRequestStartRail>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerifyAllowanceRequestStartRail
    > _stringToEnum = new()
    {
        { "agentic-token", VerifyAllowanceRequestStartRail.AgenticToken },
        { "spt", VerifyAllowanceRequestStartRail.Spt },
        { "virtual-card", VerifyAllowanceRequestStartRail.VirtualCard },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerifyAllowanceRequestStartRail,
        string
    > _enumToString = new()
    {
        { VerifyAllowanceRequestStartRail.AgenticToken, "agentic-token" },
        { VerifyAllowanceRequestStartRail.Spt, "spt" },
        { VerifyAllowanceRequestStartRail.VirtualCard, "virtual-card" },
    };

    public override VerifyAllowanceRequestStartRail Read(
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
        VerifyAllowanceRequestStartRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerifyAllowanceRequestStartRail ReadAsPropertyName(
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
        VerifyAllowanceRequestStartRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
