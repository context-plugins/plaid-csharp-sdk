using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO prescribed list that specifies financial assets in a mortgage loan transaction. Assets may be either liquid or fixed and are associated with a corresponding asset amount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetType>))]
public sealed record AssetType : StringEnum<AssetType>
{
    private AssetType(string value) : base(value)
    {
    }

    public static readonly AssetType CheckingAccount = new("CheckingAccount");

    public static readonly AssetType SavingsAccount = new("SavingsAccount");

    public static readonly AssetType Investment = new("Investment");

    public static readonly AssetType MoneyMarketFund = new("MoneyMarketFund");

    public static readonly AssetType Other = new("Other");

    public static AssetType FromValue(string value) => FromValueCore(value);
}
