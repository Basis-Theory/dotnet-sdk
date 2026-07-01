using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnrollmentProviderSerializer))]
public enum EnrollmentProvider
{
    [EnumMember(Value = "visa")]
    Visa,

    [EnumMember(Value = "mastercard")]
    Mastercard,

    [EnumMember(Value = "stripe")]
    Stripe,

    [EnumMember(Value = "visa-mock")]
    VisaMock,

    [EnumMember(Value = "mastercard-mock")]
    MastercardMock,

    [EnumMember(Value = "stripe-mock")]
    StripeMock,
}

internal class EnrollmentProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EnrollmentProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EnrollmentProvider
    > _stringToEnum = new()
    {
        { "visa", EnrollmentProvider.Visa },
        { "mastercard", EnrollmentProvider.Mastercard },
        { "stripe", EnrollmentProvider.Stripe },
        { "visa-mock", EnrollmentProvider.VisaMock },
        { "mastercard-mock", EnrollmentProvider.MastercardMock },
        { "stripe-mock", EnrollmentProvider.StripeMock },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EnrollmentProvider,
        string
    > _enumToString = new()
    {
        { EnrollmentProvider.Visa, "visa" },
        { EnrollmentProvider.Mastercard, "mastercard" },
        { EnrollmentProvider.Stripe, "stripe" },
        { EnrollmentProvider.VisaMock, "visa-mock" },
        { EnrollmentProvider.MastercardMock, "mastercard-mock" },
        { EnrollmentProvider.StripeMock, "stripe-mock" },
    };

    public override EnrollmentProvider Read(
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
        EnrollmentProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EnrollmentProvider ReadAsPropertyName(
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
        EnrollmentProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
