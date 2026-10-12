using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Description of the reason you want to evaluate risk.
/// <c>ONBOARDING</c>: user links a first bank account as part of the onboarding flow of your platform.
/// <c>NEW_ACCOUNT</c>: user links another bank account or replaces the currently linked bank account on your platform.
/// <c>INFORMATION_CHANGE</c>: user changes their information on your platform, e.g., updating their phone number.
/// <c>DORMANT_USER</c>:  you decide to re-evaluate a user that becomes active after a period of inactivity.
/// <c>OTHER</c>: any other reasons not listed here
/// Possible values:  <c>ONBOARDING</c>, <c>NEW_ACCOUNT</c>, <c>INFORMATION_CHANGE</c>, <c>DORMANT_USER</c>, <c>OTHER</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BeaconAccountRiskEvaluateEvaluationReason>))]
public sealed record BeaconAccountRiskEvaluateEvaluationReason : OpenStringEnum<BeaconAccountRiskEvaluateEvaluationReason>
{
    private BeaconAccountRiskEvaluateEvaluationReason(string value) : base(value)
    {
    }

    public static readonly BeaconAccountRiskEvaluateEvaluationReason Onboarding = new("ONBOARDING");

    public static readonly BeaconAccountRiskEvaluateEvaluationReason NewAccount = new("NEW_ACCOUNT");

    public static readonly BeaconAccountRiskEvaluateEvaluationReason InformationChange = new("INFORMATION_CHANGE");

    public static readonly BeaconAccountRiskEvaluateEvaluationReason DormantUser = new("DORMANT_USER");

    public static readonly BeaconAccountRiskEvaluateEvaluationReason Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onOnboarding,
        Func<TResult> onNewAccount,
        Func<TResult> onInformationChange,
        Func<TResult> onDormantUser,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Onboarding => onOnboarding(),
            _ when this == NewAccount => onNewAccount(),
            _ when this == InformationChange => onInformationChange(),
            _ when this == DormantUser => onDormantUser(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnboarding,
        Action onNewAccount,
        Action onInformationChange,
        Action onDormantUser,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Onboarding) onOnboarding();
        else if (this == NewAccount) onNewAccount();
        else if (this == InformationChange) onInformationChange();
        else if (this == DormantUser) onDormantUser();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
