using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Fees on the account, e.g. commission, bookkeeping, options-related.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FeeType>))]
public sealed record FeeType : OpenStringEnum<FeeType>
{
    private FeeType(string value) : base(value)
    {
    }

    public static readonly FeeType AccountFee = new("account fee");

    public static readonly FeeType Adjustment = new("adjustment");

    public static readonly FeeType Dividend = new("dividend");

    public static readonly FeeType Interest = new("interest");

    public static readonly FeeType InterestReceivable = new("interest receivable");

    public static readonly FeeType LongTermCapitalGain = new("long-term capital gain");

    public static readonly FeeType LegalFee = new("legal fee");

    public static readonly FeeType ManagementFee = new("management fee");

    public static readonly FeeType MarginExpense = new("margin expense");

    public static readonly FeeType NonQualifiedDividend = new("non-qualified dividend");

    public static readonly FeeType NonResidentTax = new("non-resident tax");

    public static readonly FeeType QualifiedDividend = new("qualified dividend");

    public static readonly FeeType ReturnOfPrincipal = new("return of principal");

    public static readonly FeeType ShortTermCapitalGain = new("short-term capital gain");

    public static readonly FeeType StockDistribution = new("stock distribution");

    public static readonly FeeType Tax = new("tax");

    public static readonly FeeType TaxWithheld = new("tax withheld");

    public static readonly FeeType TransferFee = new("transfer fee");

    public static readonly FeeType TrustFee = new("trust fee");

    public static readonly FeeType UnqualifiedGain = new("unqualified gain");

    public TResult Match<TResult>(Func<TResult> onAccountFee,
        Func<TResult> onAdjustment,
        Func<TResult> onDividend,
        Func<TResult> onInterest,
        Func<TResult> onInterestReceivable,
        Func<TResult> onLongTermCapitalGain,
        Func<TResult> onLegalFee,
        Func<TResult> onManagementFee,
        Func<TResult> onMarginExpense,
        Func<TResult> onNonQualifiedDividend,
        Func<TResult> onNonResidentTax,
        Func<TResult> onQualifiedDividend,
        Func<TResult> onReturnOfPrincipal,
        Func<TResult> onShortTermCapitalGain,
        Func<TResult> onStockDistribution,
        Func<TResult> onTax,
        Func<TResult> onTaxWithheld,
        Func<TResult> onTransferFee,
        Func<TResult> onTrustFee,
        Func<TResult> onUnqualifiedGain,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountFee => onAccountFee(),
            _ when this == Adjustment => onAdjustment(),
            _ when this == Dividend => onDividend(),
            _ when this == Interest => onInterest(),
            _ when this == InterestReceivable => onInterestReceivable(),
            _ when this == LongTermCapitalGain => onLongTermCapitalGain(),
            _ when this == LegalFee => onLegalFee(),
            _ when this == ManagementFee => onManagementFee(),
            _ when this == MarginExpense => onMarginExpense(),
            _ when this == NonQualifiedDividend => onNonQualifiedDividend(),
            _ when this == NonResidentTax => onNonResidentTax(),
            _ when this == QualifiedDividend => onQualifiedDividend(),
            _ when this == ReturnOfPrincipal => onReturnOfPrincipal(),
            _ when this == ShortTermCapitalGain => onShortTermCapitalGain(),
            _ when this == StockDistribution => onStockDistribution(),
            _ when this == Tax => onTax(),
            _ when this == TaxWithheld => onTaxWithheld(),
            _ when this == TransferFee => onTransferFee(),
            _ when this == TrustFee => onTrustFee(),
            _ when this == UnqualifiedGain => onUnqualifiedGain(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountFee,
        Action onAdjustment,
        Action onDividend,
        Action onInterest,
        Action onInterestReceivable,
        Action onLongTermCapitalGain,
        Action onLegalFee,
        Action onManagementFee,
        Action onMarginExpense,
        Action onNonQualifiedDividend,
        Action onNonResidentTax,
        Action onQualifiedDividend,
        Action onReturnOfPrincipal,
        Action onShortTermCapitalGain,
        Action onStockDistribution,
        Action onTax,
        Action onTaxWithheld,
        Action onTransferFee,
        Action onTrustFee,
        Action onUnqualifiedGain,
        Action<string> otherwise)
    {
        if (this == AccountFee) onAccountFee();
        else if (this == Adjustment) onAdjustment();
        else if (this == Dividend) onDividend();
        else if (this == Interest) onInterest();
        else if (this == InterestReceivable) onInterestReceivable();
        else if (this == LongTermCapitalGain) onLongTermCapitalGain();
        else if (this == LegalFee) onLegalFee();
        else if (this == ManagementFee) onManagementFee();
        else if (this == MarginExpense) onMarginExpense();
        else if (this == NonQualifiedDividend) onNonQualifiedDividend();
        else if (this == NonResidentTax) onNonResidentTax();
        else if (this == QualifiedDividend) onQualifiedDividend();
        else if (this == ReturnOfPrincipal) onReturnOfPrincipal();
        else if (this == ShortTermCapitalGain) onShortTermCapitalGain();
        else if (this == StockDistribution) onStockDistribution();
        else if (this == Tax) onTax();
        else if (this == TaxWithheld) onTaxWithheld();
        else if (this == TransferFee) onTransferFee();
        else if (this == TrustFee) onTrustFee();
        else if (this == UnqualifiedGain) onUnqualifiedGain();
        else otherwise(Value);
    }
}
