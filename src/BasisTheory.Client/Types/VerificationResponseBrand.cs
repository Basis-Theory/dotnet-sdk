using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerificationResponseBrandSerializer))]
public enum VerificationResponseBrand
{
    [EnumMember(Value = "visa")]
    Visa,

    [EnumMember(Value = "mastercard")]
    Mastercard,
}

internal class VerificationResponseBrandSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerificationResponseBrand>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerificationResponseBrand
    > _stringToEnum = new()
    {
        { "visa", VerificationResponseBrand.Visa },
        { "mastercard", VerificationResponseBrand.Mastercard },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerificationResponseBrand,
        string
    > _enumToString = new()
    {
        { VerificationResponseBrand.Visa, "visa" },
        { VerificationResponseBrand.Mastercard, "mastercard" },
    };

    public override VerificationResponseBrand Read(
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
        VerificationResponseBrand value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerificationResponseBrand ReadAsPropertyName(
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
        VerificationResponseBrand value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
