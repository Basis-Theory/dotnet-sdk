using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

[JsonConverter(typeof(StringEnumSerializer<WebhookStatus>))]
public enum WebhookStatus
{
    [EnumMember(Value = "enabled")]
    Enabled,

    [EnumMember(Value = "disabled")]
    Disabled,
}
