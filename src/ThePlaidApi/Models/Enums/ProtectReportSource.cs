using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The source that identified or reported the incident.
/// <para>
/// <c>INTERNAL_REVIEW</c> - Incident was identified through internal fraud investigations or review processes.
/// </para>
/// <para>
/// <c>USER_SELF_REPORTED</c> - Incident was reported directly by the affected user.
/// </para>
/// <para>
/// <c>BANK_FEEDBACK</c> - Incident was identified through bank feedback, including ACH returns and connection revocations.
/// </para>
/// <para>
/// <c>NETWORK_FEEDBACK</c> - Incident was identified through card network alerts or chargebacks.
/// </para>
/// <para>
/// <c>AUTOMATED_SYSTEM</c> - Incident was detected by automated systems such as fraud models or rule engines.
/// </para>
/// <para>
/// <c>THIRD_PARTY_ALERT</c> - Incident was identified through external vendor or consortium alerts.
/// </para>
/// <para>
/// <c>OTHER</c> - Incident was identified through a source not covered by other categories.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProtectReportSource>))]
public sealed record ProtectReportSource : OpenStringEnum<ProtectReportSource>
{
    private ProtectReportSource(string value) : base(value)
    {
    }

    public static readonly ProtectReportSource InternalReview = new("INTERNAL_REVIEW");

    public static readonly ProtectReportSource UserSelfReported = new("USER_SELF_REPORTED");

    public static readonly ProtectReportSource BankFeedback = new("BANK_FEEDBACK");

    public static readonly ProtectReportSource NetworkFeedback = new("NETWORK_FEEDBACK");

    public static readonly ProtectReportSource AutomatedSystem = new("AUTOMATED_SYSTEM");

    public static readonly ProtectReportSource ThirdPartyAlert = new("THIRD_PARTY_ALERT");

    public static readonly ProtectReportSource Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onInternalReview,
        Func<TResult> onUserSelfReported,
        Func<TResult> onBankFeedback,
        Func<TResult> onNetworkFeedback,
        Func<TResult> onAutomatedSystem,
        Func<TResult> onThirdPartyAlert,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InternalReview => onInternalReview(),
            _ when this == UserSelfReported => onUserSelfReported(),
            _ when this == BankFeedback => onBankFeedback(),
            _ when this == NetworkFeedback => onNetworkFeedback(),
            _ when this == AutomatedSystem => onAutomatedSystem(),
            _ when this == ThirdPartyAlert => onThirdPartyAlert(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onInternalReview,
        Action onUserSelfReported,
        Action onBankFeedback,
        Action onNetworkFeedback,
        Action onAutomatedSystem,
        Action onThirdPartyAlert,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == InternalReview) onInternalReview();
        else if (this == UserSelfReported) onUserSelfReported();
        else if (this == BankFeedback) onBankFeedback();
        else if (this == NetworkFeedback) onNetworkFeedback();
        else if (this == AutomatedSystem) onAutomatedSystem();
        else if (this == ThirdPartyAlert) onThirdPartyAlert();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
