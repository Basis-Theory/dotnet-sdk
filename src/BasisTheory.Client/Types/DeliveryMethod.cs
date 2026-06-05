using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(DeliveryMethodSerializer))]
public enum DeliveryMethod
{
    [EnumMember(Value = "no-delivery")]
    NoDelivery,

    [EnumMember(Value = "address-billing")]
    AddressBilling,

    [EnumMember(Value = "address-on-file")]
    AddressOnFile,

    [EnumMember(Value = "address-other")]
    AddressOther,

    [EnumMember(Value = "pickup")]
    Pickup,

    [EnumMember(Value = "electronic")]
    Electronic,
}

internal class DeliveryMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeliveryMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeliveryMethod
    > _stringToEnum = new()
    {
        { "no-delivery", DeliveryMethod.NoDelivery },
        { "address-billing", DeliveryMethod.AddressBilling },
        { "address-on-file", DeliveryMethod.AddressOnFile },
        { "address-other", DeliveryMethod.AddressOther },
        { "pickup", DeliveryMethod.Pickup },
        { "electronic", DeliveryMethod.Electronic },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeliveryMethod,
        string
    > _enumToString = new()
    {
        { DeliveryMethod.NoDelivery, "no-delivery" },
        { DeliveryMethod.AddressBilling, "address-billing" },
        { DeliveryMethod.AddressOnFile, "address-on-file" },
        { DeliveryMethod.AddressOther, "address-other" },
        { DeliveryMethod.Pickup, "pickup" },
        { DeliveryMethod.Electronic, "electronic" },
    };

    public override DeliveryMethod Read(
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
        DeliveryMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeliveryMethod ReadAsPropertyName(
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
        DeliveryMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
