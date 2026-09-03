using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StandaloneInvestmentTransactionTransferType>))]
public sealed record StandaloneInvestmentTransactionTransferType : StringEnum<StandaloneInvestmentTransactionTransferType>
{
    private StandaloneInvestmentTransactionTransferType(string value) : base(value)
    {
    }

    public static readonly StandaloneInvestmentTransactionTransferType Assignment = new("assignment");

    public static readonly StandaloneInvestmentTransactionTransferType Adjustment = new("adjustment");

    public static readonly StandaloneInvestmentTransactionTransferType Exercise = new("exercise");

    public static readonly StandaloneInvestmentTransactionTransferType Expire = new("expire");

    public static readonly StandaloneInvestmentTransactionTransferType Merger = new("merger");

    public static readonly StandaloneInvestmentTransactionTransferType Request = new("request");

    public static readonly StandaloneInvestmentTransactionTransferType Send = new("send");

    public static readonly StandaloneInvestmentTransactionTransferType SpinOff = new("spin off");

    public static readonly StandaloneInvestmentTransactionTransferType Split = new("split");

    public static readonly StandaloneInvestmentTransactionTransferType Trade = new("trade");

    public static readonly StandaloneInvestmentTransactionTransferType Transfer = new("transfer");

    public static StandaloneInvestmentTransactionTransferType FromValue(string value) => FromValueCore(value);
}
