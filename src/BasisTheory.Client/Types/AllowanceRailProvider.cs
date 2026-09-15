using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AllowanceRailProviderSerializer))]
public enum AllowanceRailProvider
{
    [EnumMember(Value = "vic")]
    Vic,

    [EnumMember(Value = "agentpay")]
    Agentpay,
}

internal class AllowanceRailProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AllowanceRailProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AllowanceRailProvider
    > _stringToEnum = new()
    {
        { "vic", AllowanceRailProvider.Vic },
        { "agentpay", AllowanceRailProvider.Agentpay },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AllowanceRailProvider,
        string
    > _enumToString = new()
    {
        { AllowanceRailProvider.Vic, "vic" },
        { AllowanceRailProvider.Agentpay, "agentpay" },
    };

    public override AllowanceRailProvider Read(
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
        AllowanceRailProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AllowanceRailProvider ReadAsPropertyName(
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
        AllowanceRailProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
