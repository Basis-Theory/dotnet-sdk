using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(SharedPaymentProviderErrorProviderSerializer))]
public enum SharedPaymentProviderErrorProvider
{
    [EnumMember(Value = "vic")]
    Vic,

    [EnumMember(Value = "agentpay")]
    Agentpay,

    [EnumMember(Value = "stripe")]
    Stripe,

    [EnumMember(Value = "link")]
    Link,

    [EnumMember(Value = "stripe_link")]
    StripeLink,
}

internal class SharedPaymentProviderErrorProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SharedPaymentProviderErrorProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SharedPaymentProviderErrorProvider
    > _stringToEnum = new()
    {
        { "vic", SharedPaymentProviderErrorProvider.Vic },
        { "agentpay", SharedPaymentProviderErrorProvider.Agentpay },
        { "stripe", SharedPaymentProviderErrorProvider.Stripe },
        { "link", SharedPaymentProviderErrorProvider.Link },
        { "stripe_link", SharedPaymentProviderErrorProvider.StripeLink },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SharedPaymentProviderErrorProvider,
        string
    > _enumToString = new()
    {
        { SharedPaymentProviderErrorProvider.Vic, "vic" },
        { SharedPaymentProviderErrorProvider.Agentpay, "agentpay" },
        { SharedPaymentProviderErrorProvider.Stripe, "stripe" },
        { SharedPaymentProviderErrorProvider.Link, "link" },
        { SharedPaymentProviderErrorProvider.StripeLink, "stripe_link" },
    };

    public override SharedPaymentProviderErrorProvider Read(
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
        SharedPaymentProviderErrorProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SharedPaymentProviderErrorProvider ReadAsPropertyName(
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
        SharedPaymentProviderErrorProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
