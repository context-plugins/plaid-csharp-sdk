using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The network or rails used for the transfer. Valid options are <c>ach</c>, <c>same-day-ach</c>, or <c>wire</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferNetwork>))]
public sealed record BankTransferNetwork : StringEnum<BankTransferNetwork>
{
    private BankTransferNetwork(string value) : base(value)
    {
    }

    public static readonly BankTransferNetwork Ach = new("ach");

    public static readonly BankTransferNetwork SameDayAch = new("same-day-ach");

    public static readonly BankTransferNetwork Wire = new("wire");

    public static BankTransferNetwork FromValue(string value) => FromValueCore(value);
}
