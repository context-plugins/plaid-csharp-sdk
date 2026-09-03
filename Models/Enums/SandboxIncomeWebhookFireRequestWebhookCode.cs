using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook codes that can be fired by this test endpoint.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SandboxIncomeWebhookFireRequestWebhookCode>))]
public sealed record SandboxIncomeWebhookFireRequestWebhookCode : StringEnum<SandboxIncomeWebhookFireRequestWebhookCode>
{
    private SandboxIncomeWebhookFireRequestWebhookCode(string value) : base(value)
    {
    }

    public static readonly SandboxIncomeWebhookFireRequestWebhookCode IncomeVerification = new("INCOME_VERIFICATION");

    public static readonly SandboxIncomeWebhookFireRequestWebhookCode IncomeVerificationRiskSignals = new("INCOME_VERIFICATION_RISK_SIGNALS");

    public static SandboxIncomeWebhookFireRequestWebhookCode FromValue(string value) => FromValueCore(value);
}
