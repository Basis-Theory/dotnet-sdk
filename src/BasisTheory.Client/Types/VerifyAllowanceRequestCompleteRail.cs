using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerifyAllowanceRequestCompleteRailSerializer))]
public enum VerifyAllowanceRequestCompleteRail
{
    [EnumMember(Value = "agentic-token")]
    AgenticToken,

    [EnumMember(Value = "virtual-card")]
    VirtualCard,
}

internal class VerifyAllowanceRequestCompleteRailSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerifyAllowanceRequestCompleteRail>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerifyAllowanceRequestCompleteRail
    > _stringToEnum = new()
    {
        { "agentic-token", VerifyAllowanceRequestCompleteRail.AgenticToken },
        { "virtual-card", VerifyAllowanceRequestCompleteRail.VirtualCard },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerifyAllowanceRequestCompleteRail,
        string
    > _enumToString = new()
    {
        { VerifyAllowanceRequestCompleteRail.AgenticToken, "agentic-token" },
        { VerifyAllowanceRequestCompleteRail.VirtualCard, "virtual-card" },
    };

    public override VerifyAllowanceRequestCompleteRail Read(
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
        VerifyAllowanceRequestCompleteRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerifyAllowanceRequestCompleteRail ReadAsPropertyName(
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
        VerifyAllowanceRequestCompleteRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
