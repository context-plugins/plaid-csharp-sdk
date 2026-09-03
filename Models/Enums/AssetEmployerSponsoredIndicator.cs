using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Whether the account is employer sponsored retirement account or not (e.g., 401K, 403b, 457, thrift savings plan)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetEmployerSponsoredIndicator>))]
public sealed record AssetEmployerSponsoredIndicator : StringEnum<AssetEmployerSponsoredIndicator>
{
    private AssetEmployerSponsoredIndicator(string value) : base(value)
    {
    }

    public static readonly AssetEmployerSponsoredIndicator Yes = new("Yes");

    public static readonly AssetEmployerSponsoredIndicator No = new("No");

    public static AssetEmployerSponsoredIndicator FromValue(string value) => FromValueCore(value);
}
