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
public sealed record TransactionCode : StringEnum<TransactionCode>
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

    public static TransactionCode FromValue(string value) => FromValueCore(value);
}
