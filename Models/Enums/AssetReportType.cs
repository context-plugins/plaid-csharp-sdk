using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates either a Fast Asset Report, which will contain only current identity and balance information, or a Full Asset Report, which will also contain historical balance information and transaction data.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetReportType>))]
public sealed record AssetReportType : StringEnum<AssetReportType>
{
    private AssetReportType(string value) : base(value)
    {
    }

    public static readonly AssetReportType Full = new("FULL");

    public static readonly AssetReportType Fast = new("FAST");

    public static AssetReportType FromValue(string value) => FromValueCore(value);
}
