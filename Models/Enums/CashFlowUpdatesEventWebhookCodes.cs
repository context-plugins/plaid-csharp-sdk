using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Webhook code for a Cash Flow Updates event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashFlowUpdatesEventWebhookCodes>))]
public sealed record CashFlowUpdatesEventWebhookCodes : StringEnum<CashFlowUpdatesEventWebhookCodes>
{
    private CashFlowUpdatesEventWebhookCodes(string value) : base(value)
    {
    }

    public static readonly CashFlowUpdatesEventWebhookCodes LargeDepositDetected = new("LARGE_DEPOSIT_DETECTED");

    public static readonly CashFlowUpdatesEventWebhookCodes LowBalanceDetected = new("LOW_BALANCE_DETECTED");

    public static readonly CashFlowUpdatesEventWebhookCodes NewLoanPaymentDetected = new("NEW_LOAN_PAYMENT_DETECTED");

    public static readonly CashFlowUpdatesEventWebhookCodes NsfOverdraftDetected = new("NSF_OVERDRAFT_DETECTED");

    public static CashFlowUpdatesEventWebhookCodes FromValue(string value) => FromValueCore(value);
}
