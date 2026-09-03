using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the UltraFICO® score.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraPartnerInsightsUltraFicoScoreVersion>))]
public sealed record CraPartnerInsightsUltraFicoScoreVersion : StringEnum<CraPartnerInsightsUltraFicoScoreVersion>
{
    private CraPartnerInsightsUltraFicoScoreVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>1.0</c> UltraFICO score version.
    /// </summary>
    public static readonly CraPartnerInsightsUltraFicoScoreVersion _10 = new("1.0");

    public static CraPartnerInsightsUltraFicoScoreVersion FromValue(string value) => FromValueCore(value);
}
