using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[JsonConverter(typeof(CreateEnrollmentRequestTypeSerializer))]
public enum CreateEnrollmentRequestType
{
    [EnumMember(Value = "agentic")]
    Agentic,

    [EnumMember(Value = "autofill")]
    Autofill,
}

internal class CreateEnrollmentRequestTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateEnrollmentRequestType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateEnrollmentRequestType
    > _stringToEnum = new()
    {
        { "agentic", CreateEnrollmentRequestType.Agentic },
        { "autofill", CreateEnrollmentRequestType.Autofill },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateEnrollmentRequestType,
        string
    > _enumToString = new()
    {
        { CreateEnrollmentRequestType.Agentic, "agentic" },
        { CreateEnrollmentRequestType.Autofill, "autofill" },
    };

    public override CreateEnrollmentRequestType Read(
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
        CreateEnrollmentRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateEnrollmentRequestType ReadAsPropertyName(
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
        CreateEnrollmentRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
