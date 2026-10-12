using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of the transaction. The supported transaction types that are returned are:
/// <c>BANK_TRANSFER:</c> a transaction which credits an e-wallet through an external bank transfer.
/// <para>
/// <c>PAYOUT:</c> a transaction which debits an e-wallet by disbursing funds to a counterparty.
/// </para>
/// <para>
/// <c>PIS_PAY_IN:</c> a payment which credits an e-wallet through Plaid's Payment Initiation Services (PIS) APIs. For more information see the <see href="https://plaid.com/docs/api/products/payment-initiation/">Payment Initiation endpoints</see>.
/// </para>
/// <para>
/// <c>REFUND:</c> a transaction which debits an e-wallet by refunding a previously initiated payment made through Plaid's <see href="https://plaid.com/docs/api/products/payment-initiation/">PIS APIs</see>.
/// </para>
/// <para>
/// <c>FUNDS_SWEEP</c>: an automated transaction which debits funds from an e-wallet to a designated client-owned account.
/// </para>
/// <para>
/// <c>RETURN</c>: an automated transaction where a debit transaction was reversed and money moved back to originating account.
/// </para>
/// <para>
/// <c>RECALL</c>: a transaction where the sending bank has requested the return of funds due to a fraud claim, technical error, or other issue associated with the payment.
/// </para>
/// <para>
/// <c>ACCOUNT_FUNDING</c>: an incoming transfer from an allowlisted account. Not automatically refunded.
/// </para>
/// <para>
/// <c>AUTO_REFUND</c>: an outgoing refund automatically initiated by Plaid in response to an unexpected <c>BANK_TRANSFER</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : OpenStringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 BankTransfer = new("BANK_TRANSFER");

    public static readonly Type5 Payout = new("PAYOUT");

    public static readonly Type5 PisPayIn = new("PIS_PAY_IN");

    public static readonly Type5 Refund = new("REFUND");

    public static readonly Type5 FundsSweep = new("FUNDS_SWEEP");

    public static readonly Type5 Return = new("RETURN");

    public static readonly Type5 Recall = new("RECALL");

    public static readonly Type5 AccountFunding = new("ACCOUNT_FUNDING");

    public static readonly Type5 AutoRefund = new("AUTO_REFUND");

    public TResult Match<TResult>(Func<TResult> onBankTransfer,
        Func<TResult> onPayout,
        Func<TResult> onPisPayIn,
        Func<TResult> onRefund,
        Func<TResult> onFundsSweep,
        Func<TResult> onReturn,
        Func<TResult> onRecall,
        Func<TResult> onAccountFunding,
        Func<TResult> onAutoRefund,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankTransfer => onBankTransfer(),
            _ when this == Payout => onPayout(),
            _ when this == PisPayIn => onPisPayIn(),
            _ when this == Refund => onRefund(),
            _ when this == FundsSweep => onFundsSweep(),
            _ when this == Return => onReturn(),
            _ when this == Recall => onRecall(),
            _ when this == AccountFunding => onAccountFunding(),
            _ when this == AutoRefund => onAutoRefund(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankTransfer,
        Action onPayout,
        Action onPisPayIn,
        Action onRefund,
        Action onFundsSweep,
        Action onReturn,
        Action onRecall,
        Action onAccountFunding,
        Action onAutoRefund,
        Action<string> otherwise)
    {
        if (this == BankTransfer) onBankTransfer();
        else if (this == Payout) onPayout();
        else if (this == PisPayIn) onPisPayIn();
        else if (this == Refund) onRefund();
        else if (this == FundsSweep) onFundsSweep();
        else if (this == Return) onReturn();
        else if (this == Recall) onRecall();
        else if (this == AccountFunding) onAccountFunding();
        else if (this == AutoRefund) onAutoRefund();
        else otherwise(Value);
    }
}
