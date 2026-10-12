using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism Insights. If not specified, will default to v3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismInsightsVersion>))]
public sealed record PrismInsightsVersion : OpenStringEnum<PrismInsightsVersion>
{
    private PrismInsightsVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>4.1</c> Prism Insights version.
    /// </summary>
    public static readonly PrismInsightsVersion _41 = new("4.1");

    /// <summary>
    /// The <c>4</c> Prism Insights version.
    /// </summary>
    public static readonly PrismInsightsVersion _4 = new("4");

    /// <summary>
    /// The <c>3</c> Prism Insights version.
    /// </summary>
    public static readonly PrismInsightsVersion _3 = new("3");

    public TResult Match<TResult>(Func<TResult> on_41,
        Func<TResult> on_4,
        Func<TResult> on_3,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _41 => on_41(),
            _ when this == _4 => on_4(),
            _ when this == _3 => on_3(),
            _ => otherwise(Value)
        };

    public void Match(Action on_41, Action on_4, Action on_3, Action<string> otherwise)
    {
        if (this == _41) on_41();
        else if (this == _4) on_4();
        else if (this == _3) on_3();
        else otherwise(Value);
    }
}
