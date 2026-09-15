using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(AllowanceRailCredentialFormatsItemSerializer))]
public enum AllowanceRailCredentialFormatsItem
{
    [EnumMember(Value = "card")]
    Card,

    [EnumMember(Value = "network-token")]
    NetworkToken,

    [EnumMember(Value = "identifier")]
    Identifier,

    [EnumMember(Value = "mpp")]
    Mpp,
}

internal class AllowanceRailCredentialFormatsItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AllowanceRailCredentialFormatsItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AllowanceRailCredentialFormatsItem
    > _stringToEnum = new()
    {
        { "card", AllowanceRailCredentialFormatsItem.Card },
        { "network-token", AllowanceRailCredentialFormatsItem.NetworkToken },
        { "identifier", AllowanceRailCredentialFormatsItem.Identifier },
        { "mpp", AllowanceRailCredentialFormatsItem.Mpp },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AllowanceRailCredentialFormatsItem,
        string
    > _enumToString = new()
    {
        { AllowanceRailCredentialFormatsItem.Card, "card" },
        { AllowanceRailCredentialFormatsItem.NetworkToken, "network-token" },
        { AllowanceRailCredentialFormatsItem.Identifier, "identifier" },
        { AllowanceRailCredentialFormatsItem.Mpp, "mpp" },
    };

    public override AllowanceRailCredentialFormatsItem Read(
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
        AllowanceRailCredentialFormatsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AllowanceRailCredentialFormatsItem ReadAsPropertyName(
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
        AllowanceRailCredentialFormatsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
