using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Allowances;

[JsonConverter(typeof(CreatePaymentCredentialRequestRailSerializer))]
public enum CreatePaymentCredentialRequestRail
{
    [EnumMember(Value = "agentic-token")]
    AgenticToken,

    [EnumMember(Value = "spt")]
    Spt,

    [EnumMember(Value = "virtual-card")]
    VirtualCard,
}

internal class CreatePaymentCredentialRequestRailSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreatePaymentCredentialRequestRail>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreatePaymentCredentialRequestRail
    > _stringToEnum = new()
    {
        { "agentic-token", CreatePaymentCredentialRequestRail.AgenticToken },
        { "spt", CreatePaymentCredentialRequestRail.Spt },
        { "virtual-card", CreatePaymentCredentialRequestRail.VirtualCard },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreatePaymentCredentialRequestRail,
        string
    > _enumToString = new()
    {
        { CreatePaymentCredentialRequestRail.AgenticToken, "agentic-token" },
        { CreatePaymentCredentialRequestRail.Spt, "spt" },
        { CreatePaymentCredentialRequestRail.VirtualCard, "virtual-card" },
    };

    public override CreatePaymentCredentialRequestRail Read(
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
        CreatePaymentCredentialRequestRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreatePaymentCredentialRequestRail ReadAsPropertyName(
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
        CreatePaymentCredentialRequestRail value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
