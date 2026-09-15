using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AllowanceVerificationResponseStatusSerializer))]
public enum AllowanceVerificationResponseStatus
{
    [EnumMember(Value = "verification_required")]
    VerificationRequired,

    [EnumMember(Value = "active")]
    Active,
}

internal class AllowanceVerificationResponseStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AllowanceVerificationResponseStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AllowanceVerificationResponseStatus
    > _stringToEnum = new()
    {
        { "verification_required", AllowanceVerificationResponseStatus.VerificationRequired },
        { "active", AllowanceVerificationResponseStatus.Active },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AllowanceVerificationResponseStatus,
        string
    > _enumToString = new()
    {
        { AllowanceVerificationResponseStatus.VerificationRequired, "verification_required" },
        { AllowanceVerificationResponseStatus.Active, "active" },
    };

    public override AllowanceVerificationResponseStatus Read(
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
        AllowanceVerificationResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AllowanceVerificationResponseStatus ReadAsPropertyName(
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
        AllowanceVerificationResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
