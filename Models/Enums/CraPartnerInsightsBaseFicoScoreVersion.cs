using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the base FICO score model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraPartnerInsightsBaseFicoScoreVersion>))]
public sealed record CraPartnerInsightsBaseFicoScoreVersion : StringEnum<CraPartnerInsightsBaseFicoScoreVersion>
{
    private CraPartnerInsightsBaseFicoScoreVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>8</c> base FICO score version.
    /// </summary>
    public static readonly CraPartnerInsightsBaseFicoScoreVersion _8 = new("8");

    /// <summary>
    /// The <c>9</c> base FICO score version.
    /// </summary>
    public static readonly CraPartnerInsightsBaseFicoScoreVersion _9 = new("9");

    /// <summary>
    /// The <c>10</c> base FICO score version.
    /// </summary>
    public static readonly CraPartnerInsightsBaseFicoScoreVersion _10 = new("10");

    /// <summary>
    /// The <c>10T</c> base FICO score version.
    /// </summary>
    public static readonly CraPartnerInsightsBaseFicoScoreVersion _10T = new("10T");

    public static CraPartnerInsightsBaseFicoScoreVersion FromValue(string value) => FromValueCore(value);
}
