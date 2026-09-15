using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(SharedPaymentRailBaseAgenticTokenProviderSerializer))]
public enum SharedPaymentRailBaseAgenticTokenProvider
{
    [EnumMember(Value = "vic")]
    Vic,

    [EnumMember(Value = "agentpay")]
    Agentpay,
}

internal class SharedPaymentRailBaseAgenticTokenProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SharedPaymentRailBaseAgenticTokenProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SharedPaymentRailBaseAgenticTokenProvider
    > _stringToEnum = new()
    {
        { "vic", SharedPaymentRailBaseAgenticTokenProvider.Vic },
        { "agentpay", SharedPaymentRailBaseAgenticTokenProvider.Agentpay },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SharedPaymentRailBaseAgenticTokenProvider,
        string
    > _enumToString = new()
    {
        { SharedPaymentRailBaseAgenticTokenProvider.Vic, "vic" },
        { SharedPaymentRailBaseAgenticTokenProvider.Agentpay, "agentpay" },
    };

    public override SharedPaymentRailBaseAgenticTokenProvider Read(
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
        SharedPaymentRailBaseAgenticTokenProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SharedPaymentRailBaseAgenticTokenProvider ReadAsPropertyName(
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
        SharedPaymentRailBaseAgenticTokenProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
