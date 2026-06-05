using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerificationResponseRedirectUriTypeSerializer))]
public enum VerificationResponseRedirectUriType
{
    [EnumMember(Value = "WEB_URI")]
    WebUri,

    [EnumMember(Value = "APP_URI")]
    AppUri,
}

internal class VerificationResponseRedirectUriTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerificationResponseRedirectUriType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerificationResponseRedirectUriType
    > _stringToEnum = new()
    {
        { "WEB_URI", VerificationResponseRedirectUriType.WebUri },
        { "APP_URI", VerificationResponseRedirectUriType.AppUri },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerificationResponseRedirectUriType,
        string
    > _enumToString = new()
    {
        { VerificationResponseRedirectUriType.WebUri, "WEB_URI" },
        { VerificationResponseRedirectUriType.AppUri, "APP_URI" },
    };

    public override VerificationResponseRedirectUriType Read(
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
        VerificationResponseRedirectUriType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerificationResponseRedirectUriType ReadAsPropertyName(
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
        VerificationResponseRedirectUriType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
