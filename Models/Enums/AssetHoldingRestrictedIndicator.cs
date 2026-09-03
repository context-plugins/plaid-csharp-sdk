using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Whether or not the stock is restricted, i.e. "Restricted" or "Not Restricted"
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetHoldingRestrictedIndicator>))]
public sealed record AssetHoldingRestrictedIndicator : StringEnum<AssetHoldingRestrictedIndicator>
{
    private AssetHoldingRestrictedIndicator(string value) : base(value)
    {
    }

    public static readonly AssetHoldingRestrictedIndicator Yes = new("Yes");

    public static readonly AssetHoldingRestrictedIndicator No = new("No");

    public static AssetHoldingRestrictedIndicator FromValue(string value) => FromValueCore(value);
}
