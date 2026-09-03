using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Asset Investment Transaction Type Enumerated derived by Vendor.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetInvestmentTransactionType>))]
public sealed record AssetInvestmentTransactionType : StringEnum<AssetInvestmentTransactionType>
{
    private AssetInvestmentTransactionType(string value) : base(value)
    {
    }

    public static readonly AssetInvestmentTransactionType Buy = new("Buy");

    public static readonly AssetInvestmentTransactionType Sell = new("Sell");

    public static readonly AssetInvestmentTransactionType Dividends = new("Dividends");

    public static readonly AssetInvestmentTransactionType Interest = new("Interest");

    public static readonly AssetInvestmentTransactionType Transfers = new("Transfers");

    public static readonly AssetInvestmentTransactionType Reinvestments = new("Reinvestments");

    public static readonly AssetInvestmentTransactionType FundsReceived = new("FundsReceived");

    public static readonly AssetInvestmentTransactionType Other = new("Other");

    public static AssetInvestmentTransactionType FromValue(string value) => FromValueCore(value);
}
