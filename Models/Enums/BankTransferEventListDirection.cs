using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates the direction of the transfer: <c>outbound</c>: for API-initiated transfers
/// <c>inbound</c>: for payments received by the FBO account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferEventListDirection>))]
public sealed record BankTransferEventListDirection : StringEnum<BankTransferEventListDirection>
{
    private BankTransferEventListDirection(string value) : base(value)
    {
    }

    public static readonly BankTransferEventListDirection Inbound = new("inbound");

    public static readonly BankTransferEventListDirection Outbound = new("outbound");

    public static BankTransferEventListDirection FromValue(string value) => FromValueCore(value);
}
