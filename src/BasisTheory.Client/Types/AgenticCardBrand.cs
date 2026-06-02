using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AgenticCardBrandSerializer))]
public enum AgenticCardBrand
{
    [EnumMember(Value = "visa")]
    Visa,

    [EnumMember(Value = "mastercard")]
    Mastercard,
}

internal class AgenticCardBrandSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AgenticCardBrand>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AgenticCardBrand
    > _stringToEnum = new()
    {
        { "visa", AgenticCardBrand.Visa },
        { "mastercard", AgenticCardBrand.Mastercard },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AgenticCardBrand,
        string
    > _enumToString = new()
    {
        { AgenticCardBrand.Visa, "visa" },
        { AgenticCardBrand.Mastercard, "mastercard" },
    };

    public override AgenticCardBrand Read(
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
        AgenticCardBrand value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AgenticCardBrand ReadAsPropertyName(
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
        AgenticCardBrand value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
