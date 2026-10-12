using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Field describing the overall user interaction signals of a behavior risk check. This value represents how familiar the user is with the personal data they provide, based on a number of signals that are collected during their session.
/// <para>
/// <c>genuine</c> indicates the user has high familiarity with the data they are providing, and that fraud is unlikely.
/// </para>
/// <para>
/// <c>neutral</c> indicates some signals are present in between <c>risky</c> and <c>genuine</c>, but there are not enough clear signals to determine an outcome.
/// </para>
/// <para>
/// <c>risky</c> indicates the user has low familiarity with the data they are providing, and that fraud is likely.
/// </para>
/// <para>
/// <c>no_data</c> indicates there is not sufficient information to give an accurate signal.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckBehaviorUserInteractionsLabel>))]
public sealed record RiskCheckBehaviorUserInteractionsLabel : OpenStringEnum<RiskCheckBehaviorUserInteractionsLabel>
{
    private RiskCheckBehaviorUserInteractionsLabel(string value) : base(value)
    {
    }

    public static readonly RiskCheckBehaviorUserInteractionsLabel Genuine = new("genuine");

    public static readonly RiskCheckBehaviorUserInteractionsLabel Neutral = new("neutral");

    public static readonly RiskCheckBehaviorUserInteractionsLabel Risky = new("risky");

    public static readonly RiskCheckBehaviorUserInteractionsLabel NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onGenuine,
        Func<TResult> onNeutral,
        Func<TResult> onRisky,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Genuine => onGenuine(),
            _ when this == Neutral => onNeutral(),
            _ when this == Risky => onRisky(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onGenuine, Action onNeutral, Action onRisky, Action onNoData, Action<string> otherwise)
    {
        if (this == Genuine) onGenuine();
        else if (this == Neutral) onNeutral();
        else if (this == Risky) onRisky();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
