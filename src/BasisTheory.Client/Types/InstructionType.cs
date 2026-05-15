using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<InstructionType>))]
public enum InstructionType
{
    [EnumMember(Value = "agentic")]
    Agentic,

    [EnumMember(Value = "autofill")]
    Autofill,
}
