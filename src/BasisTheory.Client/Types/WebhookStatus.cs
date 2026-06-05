using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(WebhookStatusSerializer))]
public enum WebhookStatus
{
    [EnumMember(Value = "enabled")]
    Enabled,

    [EnumMember(Value = "disabled")]
    Disabled,
}

internal class WebhookStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WebhookStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WebhookStatus
    > _stringToEnum = new()
    {
        { "enabled", WebhookStatus.Enabled },
        { "disabled", WebhookStatus.Disabled },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        WebhookStatus,
        string
    > _enumToString = new()
    {
        { WebhookStatus.Enabled, "enabled" },
        { WebhookStatus.Disabled, "disabled" },
    };

    public override WebhookStatus Read(
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
        WebhookStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WebhookStatus ReadAsPropertyName(
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
        WebhookStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
