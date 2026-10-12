using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The result of the rule that was triggered for this transaction.
/// <para>
/// <c>ACCEPT</c>: Accept the transaction for processing.
/// <c>REROUTE</c>: Reroute the transaction to a different payment method, as this transaction is too risky.
/// <c>REVIEW</c>: Review the transaction before proceeding.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RuleResult>))]
public sealed record RuleResult : OpenStringEnum<RuleResult>
{
    private RuleResult(string value) : base(value)
    {
    }

    public static readonly RuleResult Accept = new("ACCEPT");

    public static readonly RuleResult Reroute = new("REROUTE");

    public static readonly RuleResult Review = new("REVIEW");

    public TResult Match<TResult>(Func<TResult> onAccept,
        Func<TResult> onReroute,
        Func<TResult> onReview,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Accept => onAccept(),
            _ when this == Reroute => onReroute(),
            _ when this == Review => onReview(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccept, Action onReroute, Action onReview, Action<string> otherwise)
    {
        if (this == Accept) onAccept();
        else if (this == Reroute) onReroute();
        else if (this == Review) onReview();
        else otherwise(Value);
    }
}
