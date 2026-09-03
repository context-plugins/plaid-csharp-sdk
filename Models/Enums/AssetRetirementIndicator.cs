using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Whether or not the account is a retirement account (e.g., 401K, 403b, 457, thrift savings plans, traditional and Roth, IRAs, SEP-IRA, SIMPLE-IRA, KEOGH, state retirement savings plans, other independent and IRS-qualified employer retirement plans)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetRetirementIndicator>))]
public sealed record AssetRetirementIndicator : StringEnum<AssetRetirementIndicator>
{
    private AssetRetirementIndicator(string value) : base(value)
    {
    }

    public static readonly AssetRetirementIndicator Yes = new("Yes");

    public static readonly AssetRetirementIndicator No = new("No");

    public static AssetRetirementIndicator FromValue(string value) => FromValueCore(value);
}
