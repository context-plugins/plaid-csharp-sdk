using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Activity that modifies a cash position
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashType>))]
public sealed record CashType : OpenStringEnum<CashType>
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

    public TResult Match<TResult>(Func<TResult> onAccountFee,
        Func<TResult> onContribution,
        Func<TResult> onDeposit,
        Func<TResult> onDividend,
        Func<TResult> onStockDistribution,
        Func<TResult> onInterest,
        Func<TResult> onLegalFee,
        Func<TResult> onLongTermCapitalGain,
        Func<TResult> onManagementFee,
        Func<TResult> onMarginExpense,
        Func<TResult> onNonQualifiedDividend,
        Func<TResult> onNonResidentTax,
        Func<TResult> onPendingCredit,
        Func<TResult> onPendingDebit,
        Func<TResult> onQualifiedDividend,
        Func<TResult> onShortTermCapitalGain,
        Func<TResult> onTax,
        Func<TResult> onTaxWithheld,
        Func<TResult> onTransferFee,
        Func<TResult> onTrustFee,
        Func<TResult> onUnqualifiedGain,
        Func<TResult> onWithdrawal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountFee => onAccountFee(),
            _ when this == Contribution => onContribution(),
            _ when this == Deposit => onDeposit(),
            _ when this == Dividend => onDividend(),
            _ when this == StockDistribution => onStockDistribution(),
            _ when this == Interest => onInterest(),
            _ when this == LegalFee => onLegalFee(),
            _ when this == LongTermCapitalGain => onLongTermCapitalGain(),
            _ when this == ManagementFee => onManagementFee(),
            _ when this == MarginExpense => onMarginExpense(),
            _ when this == NonQualifiedDividend => onNonQualifiedDividend(),
            _ when this == NonResidentTax => onNonResidentTax(),
            _ when this == PendingCredit => onPendingCredit(),
            _ when this == PendingDebit => onPendingDebit(),
            _ when this == QualifiedDividend => onQualifiedDividend(),
            _ when this == ShortTermCapitalGain => onShortTermCapitalGain(),
            _ when this == Tax => onTax(),
            _ when this == TaxWithheld => onTaxWithheld(),
            _ when this == TransferFee => onTransferFee(),
            _ when this == TrustFee => onTrustFee(),
            _ when this == UnqualifiedGain => onUnqualifiedGain(),
            _ when this == Withdrawal => onWithdrawal(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountFee,
        Action onContribution,
        Action onDeposit,
        Action onDividend,
        Action onStockDistribution,
        Action onInterest,
        Action onLegalFee,
        Action onLongTermCapitalGain,
        Action onManagementFee,
        Action onMarginExpense,
        Action onNonQualifiedDividend,
        Action onNonResidentTax,
        Action onPendingCredit,
        Action onPendingDebit,
        Action onQualifiedDividend,
        Action onShortTermCapitalGain,
        Action onTax,
        Action onTaxWithheld,
        Action onTransferFee,
        Action onTrustFee,
        Action onUnqualifiedGain,
        Action onWithdrawal,
        Action<string> otherwise)
    {
        if (this == AccountFee) onAccountFee();
        else if (this == Contribution) onContribution();
        else if (this == Deposit) onDeposit();
        else if (this == Dividend) onDividend();
        else if (this == StockDistribution) onStockDistribution();
        else if (this == Interest) onInterest();
        else if (this == LegalFee) onLegalFee();
        else if (this == LongTermCapitalGain) onLongTermCapitalGain();
        else if (this == ManagementFee) onManagementFee();
        else if (this == MarginExpense) onMarginExpense();
        else if (this == NonQualifiedDividend) onNonQualifiedDividend();
        else if (this == NonResidentTax) onNonResidentTax();
        else if (this == PendingCredit) onPendingCredit();
        else if (this == PendingDebit) onPendingDebit();
        else if (this == QualifiedDividend) onQualifiedDividend();
        else if (this == ShortTermCapitalGain) onShortTermCapitalGain();
        else if (this == Tax) onTax();
        else if (this == TaxWithheld) onTaxWithheld();
        else if (this == TransferFee) onTransferFee();
        else if (this == TrustFee) onTrustFee();
        else if (this == UnqualifiedGain) onUnqualifiedGain();
        else if (this == Withdrawal) onWithdrawal();
        else otherwise(Value);
    }
}
