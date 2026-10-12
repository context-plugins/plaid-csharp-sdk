using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the UltraFICO® score.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraPartnerInsightsUltraFicoScoreVersion>))]
public sealed record CraPartnerInsightsUltraFicoScoreVersion : OpenStringEnum<CraPartnerInsightsUltraFicoScoreVersion>
{
    private CraPartnerInsightsUltraFicoScoreVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>1.0</c> UltraFICO score version.
    /// </summary>
    public static readonly CraPartnerInsightsUltraFicoScoreVersion _10 = new("1.0");

    public TResult Match<TResult>(Func<TResult> on_10, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _10 => on_10(),
            _ => otherwise(Value)
        };

    public void Match(Action on_10, Action<string> otherwise)
    {
        if (this == _10) on_10();
        else otherwise(Value);
    }
}
