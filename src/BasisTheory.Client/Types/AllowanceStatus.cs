using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AllowanceStatusSerializer))]
public enum AllowanceStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "cancelled")]
    Cancelled,

    [EnumMember(Value = "expired")]
    Expired,
}

internal class AllowanceStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AllowanceStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AllowanceStatus
    > _stringToEnum = new()
    {
        { "active", AllowanceStatus.Active },
        { "cancelled", AllowanceStatus.Cancelled },
        { "expired", AllowanceStatus.Expired },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AllowanceStatus,
        string
    > _enumToString = new()
    {
        { AllowanceStatus.Active, "active" },
        { AllowanceStatus.Cancelled, "cancelled" },
        { AllowanceStatus.Expired, "expired" },
    };

    public override AllowanceStatus Read(
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
        AllowanceStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AllowanceStatus ReadAsPropertyName(
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
        AllowanceStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
