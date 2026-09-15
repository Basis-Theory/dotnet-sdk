using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.PaymentMethods;

[JsonConverter(typeof(RailsRetryRequestRailSerializer))]
public enum RailsRetryRequestRail
{
    [EnumMember(Value = "agentic-token")]
    AgenticToken,

    [EnumMember(Value = "spt")]
    Spt,

    [EnumMember(Value = "virtual-card")]
    VirtualCard,
}

internal class RailsRetryRequestRailSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RailsRetryRequestRail>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RailsRetryRequestRail
    > _stringToEnum = new()
    {
        { "agentic-token", RailsRetryRequestRail.AgenticToken },
        { "spt", RailsRetryRequestRail.Spt },
        { "virtual-card", RailsRetryRequestRail.VirtualCard },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RailsRetryRequestRail,
        string
    > _enumToString = new()
    {
        { RailsRetryRequestRail.AgenticToken, "agentic-token" },
        { RailsRetryRequestRail.Spt, "spt" },
        { RailsRetryRequestRail.VirtualCard, "virtual-card" },
    };

    public override RailsRetryRequestRail Read(
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
        RailsRetryRequestRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RailsRetryRequestRail ReadAsPropertyName(
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
        RailsRetryRequestRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
