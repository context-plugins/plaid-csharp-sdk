using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The income category.
/// <c>BANK_INTEREST</c>: Interest earned from a bank account.
/// <c>BENEFIT_OTHER</c>: Government benefits other than retirement, unemployment, child support, or disability. Currently used only in the UK, to represent benefits such as Cost of Living Payments.
/// <c>CASH</c>: Deprecated and used only for existing legacy implementations. Has been replaced by <c>CASH_DEPOSIT</c> and <c>TRANSFER_FROM_APPLICATION</c>.
/// <c>CASH_DEPOSIT</c>: A cash or check deposit.
/// <c>CHILD_SUPPORT</c>: Child support payments received.
/// <c>GIG_ECONOMY</c>: Income earned as a gig economy worker, e.g. driving for Uber, Lyft, Postmates, DoorDash, etc.
/// <c>LONG_TERM_DISABILITY</c>: Disability payments, including Social Security disability benefits.
/// <c>OTHER</c>: Income that could not be categorized as any other income category.
/// <c>MILITARY</c>: Veterans benefits. Income earned as salary for serving in the military (e.g. through DFAS) will be classified as <c>SALARY</c> rather than <c>MILITARY</c>.
/// <c>RENTAL</c>: Income earned from a rental property. Income may be identified as rental when the payment is received through a rental platform, e.g. Airbnb; rent paid directly by the tenant to the property owner (e.g. via cash, check, or ACH) will typically not be classified as rental income.
/// <c>RETIREMENT</c>: Payments from private retirement systems, pensions, and government retirement programs, including Social Security retirement benefits.
/// <c>SALARY</c>: Payment from an employer to an earner or other form of permanent employment.
/// <c>TAX_REFUND</c>: A tax refund.
/// <c>TRANSFER_FROM_APPLICATION</c>: Deposits from a money transfer app, such as Venmo, Cash App, or Zelle.
/// <c>UNEMPLOYMENT</c>: Unemployment benefits. In the UK, includes certain low-income benefits such as the Universal Credit.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeCategory>))]
public sealed record CreditBankIncomeCategory : StringEnum<CreditBankIncomeCategory>
{
    private CreditBankIncomeCategory(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomeCategory Salary = new("SALARY");

    public static readonly CreditBankIncomeCategory Unemployment = new("UNEMPLOYMENT");

    public static readonly CreditBankIncomeCategory Cash = new("CASH");

    public static readonly CreditBankIncomeCategory GigEconomy = new("GIG_ECONOMY");

    public static readonly CreditBankIncomeCategory Rental = new("RENTAL");

    public static readonly CreditBankIncomeCategory ChildSupport = new("CHILD_SUPPORT");

    public static readonly CreditBankIncomeCategory Military = new("MILITARY");

    public static readonly CreditBankIncomeCategory Retirement = new("RETIREMENT");

    public static readonly CreditBankIncomeCategory LongTermDisability = new("LONG_TERM_DISABILITY");

    public static readonly CreditBankIncomeCategory BankInterest = new("BANK_INTEREST");

    public static readonly CreditBankIncomeCategory CashDeposit = new("CASH_DEPOSIT");

    public static readonly CreditBankIncomeCategory TransferFromApplication = new("TRANSFER_FROM_APPLICATION");

    public static readonly CreditBankIncomeCategory TaxRefund = new("TAX_REFUND");

    public static readonly CreditBankIncomeCategory BenefitOther = new("BENEFIT_OTHER");

    public static readonly CreditBankIncomeCategory Other = new("OTHER");

    public static CreditBankIncomeCategory FromValue(string value) => FromValueCore(value);
}
