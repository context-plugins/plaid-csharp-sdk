using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The action to simulate. Must be either <c>approve</c> or <c>reject</c>.
/// <list type="bullet">
///   <item><description><c>approve</c>: Simulates bank approval, transitioning the transfer to <c>settled</c> status</description></item>
///   <item><description><c>reject</c>: Simulates bank rejection, transitioning the transfer to <c>failed</c> status</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SandboxTransferRfpSimulateAction>))]
public sealed record SandboxTransferRfpSimulateAction : StringEnum<SandboxTransferRfpSimulateAction>
{
    private SandboxTransferRfpSimulateAction(string value) : base(value)
    {
    }

    public static readonly SandboxTransferRfpSimulateAction Approve = new("approve");

    public static readonly SandboxTransferRfpSimulateAction Reject = new("reject");

    public static SandboxTransferRfpSimulateAction FromValue(string value) => FromValueCore(value);
}
