using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

[JsonConverter(typeof(EnumSerializer<CreateEnrollmentRequestType>))]
public enum CreateEnrollmentRequestType
{
    [EnumMember(Value = "agentic")]
    Agentic,

    [EnumMember(Value = "autofill")]
    Autofill,
}
