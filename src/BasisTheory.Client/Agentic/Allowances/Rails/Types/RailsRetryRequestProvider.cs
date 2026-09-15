using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Allowances;

[JsonConverter(typeof(RailsRetryRequestProviderSerializer))]
public enum RailsRetryRequestProvider
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

internal class RailsRetryRequestProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RailsRetryRequestProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RailsRetryRequestProvider
    > _stringToEnum = new()
    {
        { "vic", RailsRetryRequestProvider.Vic },
        { "agentpay", RailsRetryRequestProvider.Agentpay },
        { "stripe", RailsRetryRequestProvider.Stripe },
        { "link", RailsRetryRequestProvider.Link },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RailsRetryRequestProvider,
        string
    > _enumToString = new()
    {
        { RailsRetryRequestProvider.Vic, "vic" },
        { RailsRetryRequestProvider.Agentpay, "agentpay" },
        { RailsRetryRequestProvider.Stripe, "stripe" },
        { RailsRetryRequestProvider.Link, "link" },
    };

    public override RailsRetryRequestProvider Read(
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
        RailsRetryRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RailsRetryRequestProvider ReadAsPropertyName(
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
        RailsRetryRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
