using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[JsonConverter(typeof(AllowancesListRequestStatusSerializer))]
public enum AllowancesListRequestStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "cancelled")]
    Cancelled,

    [EnumMember(Value = "expired")]
    Expired,

    [EnumMember(Value = "all")]
    All,
}

internal class AllowancesListRequestStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AllowancesListRequestStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AllowancesListRequestStatus
    > _stringToEnum = new()
    {
        { "active", AllowancesListRequestStatus.Active },
        { "cancelled", AllowancesListRequestStatus.Cancelled },
        { "expired", AllowancesListRequestStatus.Expired },
        { "all", AllowancesListRequestStatus.All },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AllowancesListRequestStatus,
        string
    > _enumToString = new()
    {
        { AllowancesListRequestStatus.Active, "active" },
        { AllowancesListRequestStatus.Cancelled, "cancelled" },
        { AllowancesListRequestStatus.Expired, "expired" },
        { AllowancesListRequestStatus.All, "all" },
    };

    public override AllowancesListRequestStatus Read(
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
        AllowancesListRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AllowancesListRequestStatus ReadAsPropertyName(
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
        AllowancesListRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
