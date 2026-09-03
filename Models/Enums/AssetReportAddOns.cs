using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Add-ons that should be included in the Asset Report.
/// <para>
/// <c>investments</c>: The Investments add-on
/// <c>fast_assets</c>: The Fast Assets add-on
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetReportAddOns>))]
public sealed record AssetReportAddOns : StringEnum<AssetReportAddOns>
{
    private AssetReportAddOns(string value) : base(value)
    {
    }

    public static readonly AssetReportAddOns Investments = new("investments");

    public static readonly AssetReportAddOns FastAssets = new("fast_assets");

    public static AssetReportAddOns FromValue(string value) => FromValueCore(value);
}
