using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(StringEnumSerializer<WebhookStatus>))]
[Serializable]
public readonly record struct WebhookStatus : IStringEnum
{
    public static readonly WebhookStatus Enabled = new(Values.Enabled);

    public static readonly WebhookStatus Disabled = new(Values.Disabled);

    public WebhookStatus(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static WebhookStatus FromCustom(string value)
    {
        return new WebhookStatus(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(WebhookStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WebhookStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WebhookStatus value) => value.Value;

    public static explicit operator WebhookStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Enabled = "enabled";

        public const string Disabled = "disabled";
    }
}
