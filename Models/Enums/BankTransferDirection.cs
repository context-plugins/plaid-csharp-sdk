using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates the direction of the transfer: <c>outbound</c> for API-initiated transfers, or <c>inbound</c> for payments received by the FBO account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferDirection>))]
public sealed record BankTransferDirection : StringEnum<BankTransferDirection>
{
    private BankTransferDirection(string value) : base(value)
    {
    }

    public static readonly BankTransferDirection Outbound = new("outbound");

    public static readonly BankTransferDirection Inbound = new("inbound");

    public static BankTransferDirection FromValue(string value) => FromValueCore(value);
}
