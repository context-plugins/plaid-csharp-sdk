using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the base FICO score model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraPartnerInsightsBaseFicoScoreVersion>))]
public sealed record CraPartnerInsightsBaseFicoScoreVersion : OpenStringEnum<CraPartnerInsightsBaseFicoScoreVersion>
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

    public TResult Match<TResult>(Func<TResult> on_8,
        Func<TResult> on_9,
        Func<TResult> on_10,
        Func<TResult> on_10T,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _8 => on_8(),
            _ when this == _9 => on_9(),
            _ when this == _10 => on_10(),
            _ when this == _10T => on_10T(),
            _ => otherwise(Value)
        };

    public void Match(Action on_8, Action on_9, Action on_10, Action on_10T, Action<string> otherwise)
    {
        if (this == _8) on_8();
        else if (this == _9) on_9();
        else if (this == _10) on_10();
        else if (this == _10T) on_10T();
        else otherwise(Value);
    }
}
