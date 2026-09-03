using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Buying an investment
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BuyType>))]
public sealed record BuyType : StringEnum<BuyType>
{
    private BuyType(string value) : base(value)
    {
    }

    public static readonly BuyType Assignment = new("assignment");

    public static readonly BuyType Contribution = new("contribution");

    public static readonly BuyType Buy = new("buy");

    public static readonly BuyType BuyToCover = new("buy to cover");

    public static readonly BuyType DividendReinvestment = new("dividend reinvestment");

    public static readonly BuyType InterestReinvestment = new("interest reinvestment");

    public static readonly BuyType LongTermCapitalGainReinvestment = new("long-term capital gain reinvestment");

    public static readonly BuyType ShortTermCapitalGainReinvestment = new("short-term capital gain reinvestment");

    public static BuyType FromValue(string value) => FromValueCore(value);
}
