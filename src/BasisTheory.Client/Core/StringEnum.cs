using System.Text.Json.Serialization;

namespace BasisTheory.Client.Core;

public interface IStringEnum : IEquatable<string>
{
    public string Value { get; }
}
