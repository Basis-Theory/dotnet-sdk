using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(StringEnumSerializer<AccountUpdaterJobStatus>))]
[Serializable]
public readonly record struct AccountUpdaterJobStatus : IStringEnum
{
    public static readonly AccountUpdaterJobStatus Pending = new(Values.Pending);

    public static readonly AccountUpdaterJobStatus Processing = new(Values.Processing);

    public static readonly AccountUpdaterJobStatus Completed = new(Values.Completed);

    public static readonly AccountUpdaterJobStatus Failed = new(Values.Failed);

    public AccountUpdaterJobStatus(string value)
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
    public static AccountUpdaterJobStatus FromCustom(string value)
    {
        return new AccountUpdaterJobStatus(value);
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

    public static bool operator ==(AccountUpdaterJobStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountUpdaterJobStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountUpdaterJobStatus value) => value.Value;

    public static explicit operator AccountUpdaterJobStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "pending";

        public const string Processing = "processing";

        public const string Completed = "completed";

        public const string Failed = "failed";
    }
}
