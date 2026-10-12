using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism CashScore. If not specified, will default to v3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismCashScoreVersion>))]
public sealed record PrismCashScoreVersion : OpenStringEnum<PrismCashScoreVersion>
{
    private PrismCashScoreVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>4.1</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _41 = new("4.1");

    /// <summary>
    /// The <c>4</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _4 = new("4");

    /// <summary>
    /// The <c>3_lite</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _3Lite = new("3_lite");

    /// <summary>
    /// The <c>3</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _3 = new("3");

    public TResult Match<TResult>(Func<TResult> on_41,
        Func<TResult> on_4,
        Func<TResult> on_3Lite,
        Func<TResult> on_3,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _41 => on_41(),
            _ when this == _4 => on_4(),
            _ when this == _3Lite => on_3Lite(),
            _ when this == _3 => on_3(),
            _ => otherwise(Value)
        };

    public void Match(Action on_41, Action on_4, Action on_3Lite, Action on_3, Action<string> otherwise)
    {
        if (this == _41) on_41();
        else if (this == _4) on_4();
        else if (this == _3Lite) on_3Lite();
        else if (this == _3) on_3();
        else otherwise(Value);
    }
}
