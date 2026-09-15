using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(PaymentCredentialProviderSerializer))]
public enum PaymentCredentialProvider
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

internal class PaymentCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentCredentialProvider
    > _stringToEnum = new()
    {
        { "vic", PaymentCredentialProvider.Vic },
        { "agentpay", PaymentCredentialProvider.Agentpay },
        { "stripe", PaymentCredentialProvider.Stripe },
        { "link", PaymentCredentialProvider.Link },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentCredentialProvider,
        string
    > _enumToString = new()
    {
        { PaymentCredentialProvider.Vic, "vic" },
        { PaymentCredentialProvider.Agentpay, "agentpay" },
        { PaymentCredentialProvider.Stripe, "stripe" },
        { PaymentCredentialProvider.Link, "link" },
    };

    public override PaymentCredentialProvider Read(
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
        PaymentCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentCredentialProvider ReadAsPropertyName(
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
        PaymentCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
