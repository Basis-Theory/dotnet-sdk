using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerifyAllowanceRequestStartProviderSerializer))]
public enum VerifyAllowanceRequestStartProvider
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

internal class VerifyAllowanceRequestStartProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerifyAllowanceRequestStartProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerifyAllowanceRequestStartProvider
    > _stringToEnum = new()
    {
        { "vic", VerifyAllowanceRequestStartProvider.Vic },
        { "agentpay", VerifyAllowanceRequestStartProvider.Agentpay },
        { "stripe", VerifyAllowanceRequestStartProvider.Stripe },
        { "link", VerifyAllowanceRequestStartProvider.Link },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerifyAllowanceRequestStartProvider,
        string
    > _enumToString = new()
    {
        { VerifyAllowanceRequestStartProvider.Vic, "vic" },
        { VerifyAllowanceRequestStartProvider.Agentpay, "agentpay" },
        { VerifyAllowanceRequestStartProvider.Stripe, "stripe" },
        { VerifyAllowanceRequestStartProvider.Link, "link" },
    };

    public override VerifyAllowanceRequestStartProvider Read(
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
        VerifyAllowanceRequestStartProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerifyAllowanceRequestStartProvider ReadAsPropertyName(
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
        VerifyAllowanceRequestStartProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
