using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status type of the student loan
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : OpenStringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 Cancelled = new("cancelled");

    public static readonly Type2 ChargedOff = new("charged off");

    public static readonly Type2 Claim = new("claim");

    public static readonly Type2 Consolidated = new("consolidated");

    public static readonly Type2 Deferment = new("deferment");

    public static readonly Type2 Delinquent = new("delinquent");

    public static readonly Type2 Discharged = new("discharged");

    public static readonly Type2 Extension = new("extension");

    public static readonly Type2 Forbearance = new("forbearance");

    public static readonly Type2 InGrace = new("in grace");

    public static readonly Type2 InMilitary = new("in military");

    public static readonly Type2 InSchool = new("in school");

    public static readonly Type2 NotFullyDisbursed = new("not fully disbursed");

    public static readonly Type2 Other = new("other");

    public static readonly Type2 PaidInFull = new("paid in full");

    public static readonly Type2 Refunded = new("refunded");

    public static readonly Type2 Repayment = new("repayment");

    public static readonly Type2 Transferred = new("transferred");

    public static readonly Type2 PendingIdr = new("pending idr");

    public TResult Match<TResult>(Func<TResult> onCancelled,
        Func<TResult> onChargedOff,
        Func<TResult> onClaim,
        Func<TResult> onConsolidated,
        Func<TResult> onDeferment,
        Func<TResult> onDelinquent,
        Func<TResult> onDischarged,
        Func<TResult> onExtension,
        Func<TResult> onForbearance,
        Func<TResult> onInGrace,
        Func<TResult> onInMilitary,
        Func<TResult> onInSchool,
        Func<TResult> onNotFullyDisbursed,
        Func<TResult> onOther,
        Func<TResult> onPaidInFull,
        Func<TResult> onRefunded,
        Func<TResult> onRepayment,
        Func<TResult> onTransferred,
        Func<TResult> onPendingIdr,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cancelled => onCancelled(),
            _ when this == ChargedOff => onChargedOff(),
            _ when this == Claim => onClaim(),
            _ when this == Consolidated => onConsolidated(),
            _ when this == Deferment => onDeferment(),
            _ when this == Delinquent => onDelinquent(),
            _ when this == Discharged => onDischarged(),
            _ when this == Extension => onExtension(),
            _ when this == Forbearance => onForbearance(),
            _ when this == InGrace => onInGrace(),
            _ when this == InMilitary => onInMilitary(),
            _ when this == InSchool => onInSchool(),
            _ when this == NotFullyDisbursed => onNotFullyDisbursed(),
            _ when this == Other => onOther(),
            _ when this == PaidInFull => onPaidInFull(),
            _ when this == Refunded => onRefunded(),
            _ when this == Repayment => onRepayment(),
            _ when this == Transferred => onTransferred(),
            _ when this == PendingIdr => onPendingIdr(),
            _ => otherwise(Value)
        };

    public void Match(Action onCancelled,
        Action onChargedOff,
        Action onClaim,
        Action onConsolidated,
        Action onDeferment,
        Action onDelinquent,
        Action onDischarged,
        Action onExtension,
        Action onForbearance,
        Action onInGrace,
        Action onInMilitary,
        Action onInSchool,
        Action onNotFullyDisbursed,
        Action onOther,
        Action onPaidInFull,
        Action onRefunded,
        Action onRepayment,
        Action onTransferred,
        Action onPendingIdr,
        Action<string> otherwise)
    {
        if (this == Cancelled) onCancelled();
        else if (this == ChargedOff) onChargedOff();
        else if (this == Claim) onClaim();
        else if (this == Consolidated) onConsolidated();
        else if (this == Deferment) onDeferment();
        else if (this == Delinquent) onDelinquent();
        else if (this == Discharged) onDischarged();
        else if (this == Extension) onExtension();
        else if (this == Forbearance) onForbearance();
        else if (this == InGrace) onInGrace();
        else if (this == InMilitary) onInMilitary();
        else if (this == InSchool) onInSchool();
        else if (this == NotFullyDisbursed) onNotFullyDisbursed();
        else if (this == Other) onOther();
        else if (this == PaidInFull) onPaidInFull();
        else if (this == Refunded) onRefunded();
        else if (this == Repayment) onRepayment();
        else if (this == Transferred) onTransferred();
        else if (this == PendingIdr) onPendingIdr();
        else otherwise(Value);
    }
}
