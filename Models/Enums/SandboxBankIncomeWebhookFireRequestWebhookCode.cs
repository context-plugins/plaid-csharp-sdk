using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook codes this endpoint can be used to test
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SandboxBankIncomeWebhookFireRequestWebhookCode>))]
public sealed record SandboxBankIncomeWebhookFireRequestWebhookCode : StringEnum<SandboxBankIncomeWebhookFireRequestWebhookCode>
{
    private SandboxBankIncomeWebhookFireRequestWebhookCode(string value) : base(value)
    {
    }

    public static readonly SandboxBankIncomeWebhookFireRequestWebhookCode BankIncomeRefreshUpdate = new("BANK_INCOME_REFRESH_UPDATE");

    public static readonly SandboxBankIncomeWebhookFireRequestWebhookCode BankIncomeRefreshComplete = new("BANK_INCOME_REFRESH_COMPLETE");

    public static SandboxBankIncomeWebhookFireRequestWebhookCode FromValue(string value) =>
        FromValueCore(value);
}
