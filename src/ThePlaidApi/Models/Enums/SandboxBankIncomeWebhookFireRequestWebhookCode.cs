using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook codes this endpoint can be used to test
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SandboxBankIncomeWebhookFireRequestWebhookCode>))]
public sealed record SandboxBankIncomeWebhookFireRequestWebhookCode : OpenStringEnum<SandboxBankIncomeWebhookFireRequestWebhookCode>
{
    private SandboxBankIncomeWebhookFireRequestWebhookCode(string value) : base(value)
    {
    }

    public static readonly SandboxBankIncomeWebhookFireRequestWebhookCode BankIncomeRefreshUpdate = new(
        "BANK_INCOME_REFRESH_UPDATE");

    public static readonly SandboxBankIncomeWebhookFireRequestWebhookCode BankIncomeRefreshComplete = new(
        "BANK_INCOME_REFRESH_COMPLETE");

    public TResult Match<TResult>(Func<TResult> onBankIncomeRefreshUpdate,
        Func<TResult> onBankIncomeRefreshComplete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankIncomeRefreshUpdate => onBankIncomeRefreshUpdate(),
            _ when this == BankIncomeRefreshComplete => onBankIncomeRefreshComplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankIncomeRefreshUpdate, Action onBankIncomeRefreshComplete, Action<string> otherwise)
    {
        if (this == BankIncomeRefreshUpdate) onBankIncomeRefreshUpdate();
        else if (this == BankIncomeRefreshComplete) onBankIncomeRefreshComplete();
        else otherwise(Value);
    }
}
