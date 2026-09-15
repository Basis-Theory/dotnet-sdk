using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AllowanceVerificationResponseProviderSerializer))]
public enum AllowanceVerificationResponseProvider
{
    [EnumMember(Value = "vic")]
    Vic,

    [EnumMember(Value = "agentpay")]
    Agentpay,

    [EnumMember(Value = "stripe")]
    Stripe,

    [EnumMember(Value = "link")]
    Link,
}

internal class AllowanceVerificationResponseProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AllowanceVerificationResponseProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AllowanceVerificationResponseProvider
    > _stringToEnum = new()
    {
        { "vic", AllowanceVerificationResponseProvider.Vic },
        { "agentpay", AllowanceVerificationResponseProvider.Agentpay },
        { "stripe", AllowanceVerificationResponseProvider.Stripe },
        { "link", AllowanceVerificationResponseProvider.Link },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AllowanceVerificationResponseProvider,
        string
    > _enumToString = new()
    {
        { AllowanceVerificationResponseProvider.Vic, "vic" },
        { AllowanceVerificationResponseProvider.Agentpay, "agentpay" },
        { AllowanceVerificationResponseProvider.Stripe, "stripe" },
        { AllowanceVerificationResponseProvider.Link, "link" },
    };

    public override AllowanceVerificationResponseProvider Read(
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
        AllowanceVerificationResponseProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AllowanceVerificationResponseProvider ReadAsPropertyName(
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
        AllowanceVerificationResponseProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
