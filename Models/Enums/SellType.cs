using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Selling an investment
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SellType>))]
public sealed record SellType : StringEnum<SellType>
{
    private SellType(string value) : base(value)
    {
    }

    public static readonly SellType Distribution = new("distribution");

    public static readonly SellType Exercise = new("exercise");

    public static readonly SellType Sell = new("sell");

    public static readonly SellType SellShort = new("sell short");

    public static SellType FromValue(string value) => FromValueCore(value);
}
