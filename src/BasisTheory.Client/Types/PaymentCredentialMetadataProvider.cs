using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(PaymentCredentialMetadataProviderSerializer))]
public enum PaymentCredentialMetadataProvider
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

internal class PaymentCredentialMetadataProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaymentCredentialMetadataProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaymentCredentialMetadataProvider
    > _stringToEnum = new()
    {
        { "vic", PaymentCredentialMetadataProvider.Vic },
        { "agentpay", PaymentCredentialMetadataProvider.Agentpay },
        { "stripe", PaymentCredentialMetadataProvider.Stripe },
        { "link", PaymentCredentialMetadataProvider.Link },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaymentCredentialMetadataProvider,
        string
    > _enumToString = new()
    {
        { PaymentCredentialMetadataProvider.Vic, "vic" },
        { PaymentCredentialMetadataProvider.Agentpay, "agentpay" },
        { PaymentCredentialMetadataProvider.Stripe, "stripe" },
        { PaymentCredentialMetadataProvider.Link, "link" },
    };

    public override PaymentCredentialMetadataProvider Read(
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
        PaymentCredentialMetadataProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaymentCredentialMetadataProvider ReadAsPropertyName(
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
        PaymentCredentialMetadataProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
