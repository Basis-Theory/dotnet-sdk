using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Allowances;

[JsonConverter(typeof(CreatePaymentCredentialRequestProviderSerializer))]
public enum CreatePaymentCredentialRequestProvider
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

internal class CreatePaymentCredentialRequestProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreatePaymentCredentialRequestProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreatePaymentCredentialRequestProvider
    > _stringToEnum = new()
    {
        { "vic", CreatePaymentCredentialRequestProvider.Vic },
        { "agentpay", CreatePaymentCredentialRequestProvider.Agentpay },
        { "stripe", CreatePaymentCredentialRequestProvider.Stripe },
        { "link", CreatePaymentCredentialRequestProvider.Link },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreatePaymentCredentialRequestProvider,
        string
    > _enumToString = new()
    {
        { CreatePaymentCredentialRequestProvider.Vic, "vic" },
        { CreatePaymentCredentialRequestProvider.Agentpay, "agentpay" },
        { CreatePaymentCredentialRequestProvider.Stripe, "stripe" },
        { CreatePaymentCredentialRequestProvider.Link, "link" },
    };

    public override CreatePaymentCredentialRequestProvider Read(
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
        CreatePaymentCredentialRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreatePaymentCredentialRequestProvider ReadAsPropertyName(
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
        CreatePaymentCredentialRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
