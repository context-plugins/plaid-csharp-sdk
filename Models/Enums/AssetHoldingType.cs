using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of holding (e.g. bond, stock, crypto, other)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetHoldingType>))]
public sealed record AssetHoldingType : StringEnum<AssetHoldingType>
{
    private AssetHoldingType(string value) : base(value)
    {
    }

    public static readonly AssetHoldingType Bond = new("Bond");

    public static readonly AssetHoldingType Stock = new("Stock");

    public static readonly AssetHoldingType Crypto = new("Crypto");

    public static readonly AssetHoldingType Other = new("Other");

    public static AssetHoldingType FromValue(string value) => FromValueCore(value);
}
