using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook codes that can be fired by this test endpoint.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SandboxIncomeWebhookFireRequestWebhookCode>))]
public sealed record SandboxIncomeWebhookFireRequestWebhookCode : OpenStringEnum<SandboxIncomeWebhookFireRequestWebhookCode>
{
    private SandboxIncomeWebhookFireRequestWebhookCode(string value) : base(value)
    {
    }

    public static readonly SandboxIncomeWebhookFireRequestWebhookCode IncomeVerification = new("INCOME_VERIFICATION");

    public static readonly SandboxIncomeWebhookFireRequestWebhookCode IncomeVerificationRiskSignals = new(
        "INCOME_VERIFICATION_RISK_SIGNALS");

    public TResult Match<TResult>(Func<TResult> onIncomeVerification,
        Func<TResult> onIncomeVerificationRiskSignals,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IncomeVerification => onIncomeVerification(),
            _ when this == IncomeVerificationRiskSignals => onIncomeVerificationRiskSignals(),
            _ => otherwise(Value)
        };

    public void Match(Action onIncomeVerification, Action onIncomeVerificationRiskSignals, Action<string> otherwise)
    {
        if (this == IncomeVerification) onIncomeVerification();
        else if (this == IncomeVerificationRiskSignals) onIncomeVerificationRiskSignals();
        else otherwise(Value);
    }
}
