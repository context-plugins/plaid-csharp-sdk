using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Activity that modifies a cash position
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashType>))]
public sealed record CashType : StringEnum<CashType>
{
    private CashType(string value) : base(value)
    {
    }

    public static readonly CashType AccountFee = new("account fee");

    public static readonly CashType Contribution = new("contribution");

    public static readonly CashType Deposit = new("deposit");

    public static readonly CashType Dividend = new("dividend");

    public static readonly CashType StockDistribution = new("stock distribution");

    public static readonly CashType Interest = new("interest");

    public static readonly CashType LegalFee = new("legal fee");

    public static readonly CashType LongTermCapitalGain = new("long-term capital gain");

    public static readonly CashType ManagementFee = new("management fee");

    public static readonly CashType MarginExpense = new("margin expense");

    public static readonly CashType NonQualifiedDividend = new("non-qualified dividend");

    public static readonly CashType NonResidentTax = new("non-resident tax");

    public static readonly CashType PendingCredit = new("pending credit");

    public static readonly CashType PendingDebit = new("pending debit");

    public static readonly CashType QualifiedDividend = new("qualified dividend");

    public static readonly CashType ShortTermCapitalGain = new("short-term capital gain");

    public static readonly CashType Tax = new("tax");

    public static readonly CashType TaxWithheld = new("tax withheld");

    public static readonly CashType TransferFee = new("transfer fee");

    public static readonly CashType TrustFee = new("trust fee");

    public static readonly CashType UnqualifiedGain = new("unqualified gain");

    public static readonly CashType Withdrawal = new("withdrawal");

    public static CashType FromValue(string value) => FromValueCore(value);
}
