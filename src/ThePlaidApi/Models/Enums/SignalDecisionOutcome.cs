using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The payment decision from the risk assessment.
/// <para>
/// <c>APPROVE</c>: approve the transaction without requiring further actions from your customers. For example, use this field if you are placing a standard hold for all the approved transactions before making funds available to your customers. You should also use this field if you decide to accelerate the fund availability for your customers.
/// </para>
/// <para>
/// <c>REVIEW</c>: the transaction requires manual review
/// </para>
/// <para>
/// <c>REJECT</c>: reject the transaction
/// </para>
/// <para>
/// <c>TAKE_OTHER_RISK_MEASURES</c>: for example, placing a longer hold on funds than those approved transactions or introducing customer frictions such as step-up verification/authentication
/// </para>
/// <para>
/// <c>NOT_EVALUATED</c>: if only logging the results without using them
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SignalDecisionOutcome>))]
public sealed record SignalDecisionOutcome : OpenStringEnum<SignalDecisionOutcome>
{
    private SignalDecisionOutcome(string value) : base(value)
    {
    }

    public static readonly SignalDecisionOutcome Approve = new("APPROVE");

    public static readonly SignalDecisionOutcome Review = new("REVIEW");

    public static readonly SignalDecisionOutcome Reject = new("REJECT");

    public static readonly SignalDecisionOutcome TakeOtherRiskMeasures = new("TAKE_OTHER_RISK_MEASURES");

    public static readonly SignalDecisionOutcome NotEvaluated = new("NOT_EVALUATED");

    public TResult Match<TResult>(Func<TResult> onApprove,
        Func<TResult> onReview,
        Func<TResult> onReject,
        Func<TResult> onTakeOtherRiskMeasures,
        Func<TResult> onNotEvaluated,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Approve => onApprove(),
            _ when this == Review => onReview(),
            _ when this == Reject => onReject(),
            _ when this == TakeOtherRiskMeasures => onTakeOtherRiskMeasures(),
            _ when this == NotEvaluated => onNotEvaluated(),
            _ => otherwise(Value)
        };

    public void Match(Action onApprove,
        Action onReview,
        Action onReject,
        Action onTakeOtherRiskMeasures,
        Action onNotEvaluated,
        Action<string> otherwise)
    {
        if (this == Approve) onApprove();
        else if (this == Review) onReview();
        else if (this == Reject) onReject();
        else if (this == TakeOtherRiskMeasures) onTakeOtherRiskMeasures();
        else if (this == NotEvaluated) onNotEvaluated();
        else otherwise(Value);
    }
}
