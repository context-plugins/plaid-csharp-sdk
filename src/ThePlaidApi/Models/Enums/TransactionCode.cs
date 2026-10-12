using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An identifier classifying the transaction type.
/// <para>
/// This field is populated for European institutions, as well as certain institutions in the United States. For institutions where this classification is not available, this field is set to <c>null</c>.
/// </para>
/// <para>
/// <c>adjustment:</c> Bank adjustment
/// </para>
/// <para>
/// <c>atm:</c> Cash deposit or withdrawal via an automated teller machine
/// </para>
/// <para>
/// <c>bank charge:</c> Charge or fee levied by the institution
/// </para>
/// <para>
/// <c>bill payment</c>: Payment of a bill
/// </para>
/// <para>
/// <c>cash:</c> Cash deposit or withdrawal
/// </para>
/// <para>
/// <c>cash advance:</c> Cash advance drawn against a credit card or line of credit
/// </para>
/// <para>
/// <c>cashback:</c> Cash withdrawal while making a debit card purchase
/// </para>
/// <para>
/// <c>cheque:</c> Document ordering the payment of money to another person or organization
/// </para>
/// <para>
/// <c>direct debit:</c> Automatic withdrawal of funds initiated by a third party at a regular interval
/// </para>
/// <para>
/// <c>interest:</c> Interest earned or incurred
/// </para>
/// <para>
/// <c>late fee:</c> Fee associated with a late or past-due payment
/// </para>
/// <para>
/// <c>membership fee:</c> Annual or recurring membership fee
/// </para>
/// <para>
/// <c>payment:</c> One-off outbound payment not classified as a bill payment, direct debit, or standing order
/// </para>
/// <para>
/// <c>purchase:</c> Purchase made with a debit or credit card
/// </para>
/// <para>
/// <c>refund:</c> Merchant credit or return, such as a refund of a prior purchase
/// </para>
/// <para>
/// <c>returned item fee:</c> Fee for a returned item, such as a returned check or stop payment
/// </para>
/// <para>
/// <c>standing order:</c> Payment instructed by the account holder to a third party at a regular interval
/// </para>
/// <para>
/// <c>transfer:</c> Transfer of money between accounts
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionCode>))]
public sealed record TransactionCode : OpenStringEnum<TransactionCode>
{
    private TransactionCode(string value) : base(value)
    {
    }

    public static readonly TransactionCode Adjustment = new("adjustment");

    public static readonly TransactionCode Atm = new("atm");

    public static readonly TransactionCode BankCharge = new("bank charge");

    public static readonly TransactionCode BillPayment = new("bill payment");

    public static readonly TransactionCode Cash = new("cash");

    public static readonly TransactionCode CashAdvance = new("cash advance");

    public static readonly TransactionCode Cashback = new("cashback");

    public static readonly TransactionCode Cheque = new("cheque");

    public static readonly TransactionCode DirectDebit = new("direct debit");

    public static readonly TransactionCode Interest = new("interest");

    public static readonly TransactionCode LateFee = new("late fee");

    public static readonly TransactionCode MembershipFee = new("membership fee");

    public static readonly TransactionCode Payment = new("payment");

    public static readonly TransactionCode Purchase = new("purchase");

    public static readonly TransactionCode Refund = new("refund");

    public static readonly TransactionCode ReturnedItemFee = new("returned item fee");

    public static readonly TransactionCode StandingOrder = new("standing order");

    public static readonly TransactionCode Transfer = new("transfer");

    public TResult Match<TResult>(Func<TResult> onAdjustment,
        Func<TResult> onAtm,
        Func<TResult> onBankCharge,
        Func<TResult> onBillPayment,
        Func<TResult> onCash,
        Func<TResult> onCashAdvance,
        Func<TResult> onCashback,
        Func<TResult> onCheque,
        Func<TResult> onDirectDebit,
        Func<TResult> onInterest,
        Func<TResult> onLateFee,
        Func<TResult> onMembershipFee,
        Func<TResult> onPayment,
        Func<TResult> onPurchase,
        Func<TResult> onRefund,
        Func<TResult> onReturnedItemFee,
        Func<TResult> onStandingOrder,
        Func<TResult> onTransfer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Adjustment => onAdjustment(),
            _ when this == Atm => onAtm(),
            _ when this == BankCharge => onBankCharge(),
            _ when this == BillPayment => onBillPayment(),
            _ when this == Cash => onCash(),
            _ when this == CashAdvance => onCashAdvance(),
            _ when this == Cashback => onCashback(),
            _ when this == Cheque => onCheque(),
            _ when this == DirectDebit => onDirectDebit(),
            _ when this == Interest => onInterest(),
            _ when this == LateFee => onLateFee(),
            _ when this == MembershipFee => onMembershipFee(),
            _ when this == Payment => onPayment(),
            _ when this == Purchase => onPurchase(),
            _ when this == Refund => onRefund(),
            _ when this == ReturnedItemFee => onReturnedItemFee(),
            _ when this == StandingOrder => onStandingOrder(),
            _ when this == Transfer => onTransfer(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdjustment,
        Action onAtm,
        Action onBankCharge,
        Action onBillPayment,
        Action onCash,
        Action onCashAdvance,
        Action onCashback,
        Action onCheque,
        Action onDirectDebit,
        Action onInterest,
        Action onLateFee,
        Action onMembershipFee,
        Action onPayment,
        Action onPurchase,
        Action onRefund,
        Action onReturnedItemFee,
        Action onStandingOrder,
        Action onTransfer,
        Action<string> otherwise)
    {
        if (this == Adjustment) onAdjustment();
        else if (this == Atm) onAtm();
        else if (this == BankCharge) onBankCharge();
        else if (this == BillPayment) onBillPayment();
        else if (this == Cash) onCash();
        else if (this == CashAdvance) onCashAdvance();
        else if (this == Cashback) onCashback();
        else if (this == Cheque) onCheque();
        else if (this == DirectDebit) onDirectDebit();
        else if (this == Interest) onInterest();
        else if (this == LateFee) onLateFee();
        else if (this == MembershipFee) onMembershipFee();
        else if (this == Payment) onPayment();
        else if (this == Purchase) onPurchase();
        else if (this == Refund) onRefund();
        else if (this == ReturnedItemFee) onReturnedItemFee();
        else if (this == StandingOrder) onStandingOrder();
        else if (this == Transfer) onTransfer();
        else otherwise(Value);
    }
}
