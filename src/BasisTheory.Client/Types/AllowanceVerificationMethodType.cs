using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AllowanceVerificationMethodTypeSerializer))]
public enum AllowanceVerificationMethodType
{
    [EnumMember(Value = "sms")]
    Sms,

    [EnumMember(Value = "email")]
    Email,

    [EnumMember(Value = "otponlinebanking")]
    Otponlinebanking,
}

internal class AllowanceVerificationMethodTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AllowanceVerificationMethodType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AllowanceVerificationMethodType
    > _stringToEnum = new()
    {
        { "sms", AllowanceVerificationMethodType.Sms },
        { "email", AllowanceVerificationMethodType.Email },
        { "otponlinebanking", AllowanceVerificationMethodType.Otponlinebanking },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AllowanceVerificationMethodType,
        string
    > _enumToString = new()
    {
        { AllowanceVerificationMethodType.Sms, "sms" },
        { AllowanceVerificationMethodType.Email, "email" },
        { AllowanceVerificationMethodType.Otponlinebanking, "otponlinebanking" },
    };

    public override AllowanceVerificationMethodType Read(
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
        AllowanceVerificationMethodType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AllowanceVerificationMethodType ReadAsPropertyName(
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
        AllowanceVerificationMethodType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
