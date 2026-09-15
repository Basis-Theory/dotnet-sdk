using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Allowances;

[JsonConverter(typeof(CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethodSerializer))]
public enum CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod
{
    [EnumMember(Value = "stripe")]
    Stripe,

    [EnumMember(Value = "spt")]
    Spt,

    [EnumMember(Value = "card")]
    Card,
}

internal class CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod
    > _stringToEnum = new()
    {
        { "stripe", CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod.Stripe },
        { "spt", CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod.Spt },
        { "card", CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod.Card },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod,
        string
    > _enumToString = new()
    {
        { CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod.Stripe, "stripe" },
        { CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod.Spt, "spt" },
        { CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod.Card, "card" },
    };

    public override CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod Read(
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
        CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod ReadAsPropertyName(
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
        CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
