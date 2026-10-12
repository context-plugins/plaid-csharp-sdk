using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Webhook code for a Cash Flow Updates event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashFlowUpdatesEventWebhookCodes>))]
public sealed record CashFlowUpdatesEventWebhookCodes : OpenStringEnum<CashFlowUpdatesEventWebhookCodes>
{
    private CashFlowUpdatesEventWebhookCodes(string value) : base(value)
    {
    }

    public static readonly CashFlowUpdatesEventWebhookCodes LargeDepositDetected = new("LARGE_DEPOSIT_DETECTED");

    public static readonly CashFlowUpdatesEventWebhookCodes LowBalanceDetected = new("LOW_BALANCE_DETECTED");

    public static readonly CashFlowUpdatesEventWebhookCodes NewLoanPaymentDetected = new("NEW_LOAN_PAYMENT_DETECTED");

    public static readonly CashFlowUpdatesEventWebhookCodes NsfOverdraftDetected = new("NSF_OVERDRAFT_DETECTED");

    public TResult Match<TResult>(Func<TResult> onLargeDepositDetected,
        Func<TResult> onLowBalanceDetected,
        Func<TResult> onNewLoanPaymentDetected,
        Func<TResult> onNsfOverdraftDetected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LargeDepositDetected => onLargeDepositDetected(),
            _ when this == LowBalanceDetected => onLowBalanceDetected(),
            _ when this == NewLoanPaymentDetected => onNewLoanPaymentDetected(),
            _ when this == NsfOverdraftDetected => onNsfOverdraftDetected(),
            _ => otherwise(Value)
        };

    public void Match(Action onLargeDepositDetected,
        Action onLowBalanceDetected,
        Action onNewLoanPaymentDetected,
        Action onNsfOverdraftDetected,
        Action<string> otherwise)
    {
        if (this == LargeDepositDetected) onLargeDepositDetected();
        else if (this == LowBalanceDetected) onLowBalanceDetected();
        else if (this == NewLoanPaymentDetected) onNewLoanPaymentDetected();
        else if (this == NsfOverdraftDetected) onNsfOverdraftDetected();
        else otherwise(Value);
    }
}
