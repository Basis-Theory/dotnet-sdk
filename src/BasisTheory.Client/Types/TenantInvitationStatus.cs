using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(StringEnumSerializer<TenantInvitationStatus>))]
[Serializable]
public readonly record struct TenantInvitationStatus : IStringEnum
{
    public static readonly TenantInvitationStatus Pending = new(Values.Pending);

    public static readonly TenantInvitationStatus Expired = new(Values.Expired);

    public TenantInvitationStatus(string value)
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
    public static TenantInvitationStatus FromCustom(string value)
    {
        return new TenantInvitationStatus(value);
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

    public static bool operator ==(TenantInvitationStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TenantInvitationStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TenantInvitationStatus value) => value.Value;

    public static explicit operator TenantInvitationStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "PENDING";

        public const string Expired = "EXPIRED";
    }
}
