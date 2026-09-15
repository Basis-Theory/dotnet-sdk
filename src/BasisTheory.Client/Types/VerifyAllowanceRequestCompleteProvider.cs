using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerifyAllowanceRequestCompleteProviderSerializer))]
public enum VerifyAllowanceRequestCompleteProvider
{
    [EnumMember(Value = "agentpay")]
    Agentpay,

    [EnumMember(Value = "link")]
    Link,
}

internal class VerifyAllowanceRequestCompleteProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerifyAllowanceRequestCompleteProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerifyAllowanceRequestCompleteProvider
    > _stringToEnum = new()
    {
        { "agentpay", VerifyAllowanceRequestCompleteProvider.Agentpay },
        { "link", VerifyAllowanceRequestCompleteProvider.Link },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerifyAllowanceRequestCompleteProvider,
        string
    > _enumToString = new()
    {
        { VerifyAllowanceRequestCompleteProvider.Agentpay, "agentpay" },
        { VerifyAllowanceRequestCompleteProvider.Link, "link" },
    };

    public override VerifyAllowanceRequestCompleteProvider Read(
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
        VerifyAllowanceRequestCompleteProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerifyAllowanceRequestCompleteProvider ReadAsPropertyName(
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
        VerifyAllowanceRequestCompleteProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
