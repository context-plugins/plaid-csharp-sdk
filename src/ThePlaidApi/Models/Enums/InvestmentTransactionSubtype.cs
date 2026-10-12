using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// For descriptions of possible transaction types and subtypes, see the <see href="https://plaid.com/docs/api/accounts/#investment-transaction-types-schema">Investment transaction types schema</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvestmentTransactionSubtype>))]
public sealed record InvestmentTransactionSubtype : OpenStringEnum<InvestmentTransactionSubtype>
{
    private InvestmentTransactionSubtype(string value) : base(value)
    {
    }

    public static readonly InvestmentTransactionSubtype AccountFee = new("account fee");

    public static readonly InvestmentTransactionSubtype Adjustment = new("adjustment");

    public static readonly InvestmentTransactionSubtype Assignment = new("assignment");

    public static readonly InvestmentTransactionSubtype Buy = new("buy");

    public static readonly InvestmentTransactionSubtype BuyToCover = new("buy to cover");

    public static readonly InvestmentTransactionSubtype Contribution = new("contribution");

    public static readonly InvestmentTransactionSubtype Deposit = new("deposit");

    public static readonly InvestmentTransactionSubtype Distribution = new("distribution");

    public static readonly InvestmentTransactionSubtype Dividend = new("dividend");

    public static readonly InvestmentTransactionSubtype DividendReinvestment = new("dividend reinvestment");

    public static readonly InvestmentTransactionSubtype Exercise = new("exercise");

    public static readonly InvestmentTransactionSubtype Expire = new("expire");

    public static readonly InvestmentTransactionSubtype FundFee = new("fund fee");

    public static readonly InvestmentTransactionSubtype Interest = new("interest");

    public static readonly InvestmentTransactionSubtype InterestReceivable = new("interest receivable");

    public static readonly InvestmentTransactionSubtype InterestReinvestment = new("interest reinvestment");

    public static readonly InvestmentTransactionSubtype LegalFee = new("legal fee");

    public static readonly InvestmentTransactionSubtype LoanPayment = new("loan payment");

    public static readonly InvestmentTransactionSubtype LongTermCapitalGain = new("long-term capital gain");

    public static readonly InvestmentTransactionSubtype LongTermCapitalGainReinvestment = new(
        "long-term capital gain reinvestment");

    public static readonly InvestmentTransactionSubtype ManagementFee = new("management fee");

    public static readonly InvestmentTransactionSubtype MarginExpense = new("margin expense");

    public static readonly InvestmentTransactionSubtype Merger = new("merger");

    public static readonly InvestmentTransactionSubtype MiscellaneousFee = new("miscellaneous fee");

    public static readonly InvestmentTransactionSubtype NonQualifiedDividend = new("non-qualified dividend");

    public static readonly InvestmentTransactionSubtype NonResidentTax = new("non-resident tax");

    public static readonly InvestmentTransactionSubtype PendingCredit = new("pending credit");

    public static readonly InvestmentTransactionSubtype PendingDebit = new("pending debit");

    public static readonly InvestmentTransactionSubtype QualifiedDividend = new("qualified dividend");

    public static readonly InvestmentTransactionSubtype Rebalance = new("rebalance");

    public static readonly InvestmentTransactionSubtype ReturnOfPrincipal = new("return of principal");

    public static readonly InvestmentTransactionSubtype Request = new("request");

    public static readonly InvestmentTransactionSubtype Sell = new("sell");

    public static readonly InvestmentTransactionSubtype SellShort = new("sell short");

    public static readonly InvestmentTransactionSubtype Send = new("send");

    public static readonly InvestmentTransactionSubtype ShortTermCapitalGain = new("short-term capital gain");

    public static readonly InvestmentTransactionSubtype ShortTermCapitalGainReinvestment = new(
        "short-term capital gain reinvestment");

    public static readonly InvestmentTransactionSubtype SpinOff = new("spin off");

    public static readonly InvestmentTransactionSubtype Split = new("split");

    public static readonly InvestmentTransactionSubtype StockDistribution = new("stock distribution");

    public static readonly InvestmentTransactionSubtype Tax = new("tax");

    public static readonly InvestmentTransactionSubtype TaxWithheld = new("tax withheld");

    public static readonly InvestmentTransactionSubtype Trade = new("trade");

    public static readonly InvestmentTransactionSubtype Transfer = new("transfer");

    public static readonly InvestmentTransactionSubtype TransferFee = new("transfer fee");

    public static readonly InvestmentTransactionSubtype TrustFee = new("trust fee");

    public static readonly InvestmentTransactionSubtype UnqualifiedGain = new("unqualified gain");

    public static readonly InvestmentTransactionSubtype Withdrawal = new("withdrawal");

    public TResult Match<TResult>(Func<TResult> onAccountFee,
        Func<TResult> onAdjustment,
        Func<TResult> onAssignment,
        Func<TResult> onBuy,
        Func<TResult> onBuyToCover,
        Func<TResult> onContribution,
        Func<TResult> onDeposit,
        Func<TResult> onDistribution,
        Func<TResult> onDividend,
        Func<TResult> onDividendReinvestment,
        Func<TResult> onExercise,
        Func<TResult> onExpire,
        Func<TResult> onFundFee,
        Func<TResult> onInterest,
        Func<TResult> onInterestReceivable,
        Func<TResult> onInterestReinvestment,
        Func<TResult> onLegalFee,
        Func<TResult> onLoanPayment,
        Func<TResult> onLongTermCapitalGain,
        Func<TResult> onLongTermCapitalGainReinvestment,
        Func<TResult> onManagementFee,
        Func<TResult> onMarginExpense,
        Func<TResult> onMerger,
        Func<TResult> onMiscellaneousFee,
        Func<TResult> onNonQualifiedDividend,
        Func<TResult> onNonResidentTax,
        Func<TResult> onPendingCredit,
        Func<TResult> onPendingDebit,
        Func<TResult> onQualifiedDividend,
        Func<TResult> onRebalance,
        Func<TResult> onReturnOfPrincipal,
        Func<TResult> onRequest,
        Func<TResult> onSell,
        Func<TResult> onSellShort,
        Func<TResult> onSend,
        Func<TResult> onShortTermCapitalGain,
        Func<TResult> onShortTermCapitalGainReinvestment,
        Func<TResult> onSpinOff,
        Func<TResult> onSplit,
        Func<TResult> onStockDistribution,
        Func<TResult> onTax,
        Func<TResult> onTaxWithheld,
        Func<TResult> onTrade,
        Func<TResult> onTransfer,
        Func<TResult> onTransferFee,
        Func<TResult> onTrustFee,
        Func<TResult> onUnqualifiedGain,
        Func<TResult> onWithdrawal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountFee => onAccountFee(),
            _ when this == Adjustment => onAdjustment(),
            _ when this == Assignment => onAssignment(),
            _ when this == Buy => onBuy(),
            _ when this == BuyToCover => onBuyToCover(),
            _ when this == Contribution => onContribution(),
            _ when this == Deposit => onDeposit(),
            _ when this == Distribution => onDistribution(),
            _ when this == Dividend => onDividend(),
            _ when this == DividendReinvestment => onDividendReinvestment(),
            _ when this == Exercise => onExercise(),
            _ when this == Expire => onExpire(),
            _ when this == FundFee => onFundFee(),
            _ when this == Interest => onInterest(),
            _ when this == InterestReceivable => onInterestReceivable(),
            _ when this == InterestReinvestment => onInterestReinvestment(),
            _ when this == LegalFee => onLegalFee(),
            _ when this == LoanPayment => onLoanPayment(),
            _ when this == LongTermCapitalGain => onLongTermCapitalGain(),
            _ when this == LongTermCapitalGainReinvestment => onLongTermCapitalGainReinvestment(),
            _ when this == ManagementFee => onManagementFee(),
            _ when this == MarginExpense => onMarginExpense(),
            _ when this == Merger => onMerger(),
            _ when this == MiscellaneousFee => onMiscellaneousFee(),
            _ when this == NonQualifiedDividend => onNonQualifiedDividend(),
            _ when this == NonResidentTax => onNonResidentTax(),
            _ when this == PendingCredit => onPendingCredit(),
            _ when this == PendingDebit => onPendingDebit(),
            _ when this == QualifiedDividend => onQualifiedDividend(),
            _ when this == Rebalance => onRebalance(),
            _ when this == ReturnOfPrincipal => onReturnOfPrincipal(),
            _ when this == Request => onRequest(),
            _ when this == Sell => onSell(),
            _ when this == SellShort => onSellShort(),
            _ when this == Send => onSend(),
            _ when this == ShortTermCapitalGain => onShortTermCapitalGain(),
            _ when this == ShortTermCapitalGainReinvestment => onShortTermCapitalGainReinvestment(),
            _ when this == SpinOff => onSpinOff(),
            _ when this == Split => onSplit(),
            _ when this == StockDistribution => onStockDistribution(),
            _ when this == Tax => onTax(),
            _ when this == TaxWithheld => onTaxWithheld(),
            _ when this == Trade => onTrade(),
            _ when this == Transfer => onTransfer(),
            _ when this == TransferFee => onTransferFee(),
            _ when this == TrustFee => onTrustFee(),
            _ when this == UnqualifiedGain => onUnqualifiedGain(),
            _ when this == Withdrawal => onWithdrawal(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountFee,
        Action onAdjustment,
        Action onAssignment,
        Action onBuy,
        Action onBuyToCover,
        Action onContribution,
        Action onDeposit,
        Action onDistribution,
        Action onDividend,
        Action onDividendReinvestment,
        Action onExercise,
        Action onExpire,
        Action onFundFee,
        Action onInterest,
        Action onInterestReceivable,
        Action onInterestReinvestment,
        Action onLegalFee,
        Action onLoanPayment,
        Action onLongTermCapitalGain,
        Action onLongTermCapitalGainReinvestment,
        Action onManagementFee,
        Action onMarginExpense,
        Action onMerger,
        Action onMiscellaneousFee,
        Action onNonQualifiedDividend,
        Action onNonResidentTax,
        Action onPendingCredit,
        Action onPendingDebit,
        Action onQualifiedDividend,
        Action onRebalance,
        Action onReturnOfPrincipal,
        Action onRequest,
        Action onSell,
        Action onSellShort,
        Action onSend,
        Action onShortTermCapitalGain,
        Action onShortTermCapitalGainReinvestment,
        Action onSpinOff,
        Action onSplit,
        Action onStockDistribution,
        Action onTax,
        Action onTaxWithheld,
        Action onTrade,
        Action onTransfer,
        Action onTransferFee,
        Action onTrustFee,
        Action onUnqualifiedGain,
        Action onWithdrawal,
        Action<string> otherwise)
    {
        if (this == AccountFee) onAccountFee();
        else if (this == Adjustment) onAdjustment();
        else if (this == Assignment) onAssignment();
        else if (this == Buy) onBuy();
        else if (this == BuyToCover) onBuyToCover();
        else if (this == Contribution) onContribution();
        else if (this == Deposit) onDeposit();
        else if (this == Distribution) onDistribution();
        else if (this == Dividend) onDividend();
        else if (this == DividendReinvestment) onDividendReinvestment();
        else if (this == Exercise) onExercise();
        else if (this == Expire) onExpire();
        else if (this == FundFee) onFundFee();
        else if (this == Interest) onInterest();
        else if (this == InterestReceivable) onInterestReceivable();
        else if (this == InterestReinvestment) onInterestReinvestment();
        else if (this == LegalFee) onLegalFee();
        else if (this == LoanPayment) onLoanPayment();
        else if (this == LongTermCapitalGain) onLongTermCapitalGain();
        else if (this == LongTermCapitalGainReinvestment) onLongTermCapitalGainReinvestment();
        else if (this == ManagementFee) onManagementFee();
        else if (this == MarginExpense) onMarginExpense();
        else if (this == Merger) onMerger();
        else if (this == MiscellaneousFee) onMiscellaneousFee();
        else if (this == NonQualifiedDividend) onNonQualifiedDividend();
        else if (this == NonResidentTax) onNonResidentTax();
        else if (this == PendingCredit) onPendingCredit();
        else if (this == PendingDebit) onPendingDebit();
        else if (this == QualifiedDividend) onQualifiedDividend();
        else if (this == Rebalance) onRebalance();
        else if (this == ReturnOfPrincipal) onReturnOfPrincipal();
        else if (this == Request) onRequest();
        else if (this == Sell) onSell();
        else if (this == SellShort) onSellShort();
        else if (this == Send) onSend();
        else if (this == ShortTermCapitalGain) onShortTermCapitalGain();
        else if (this == ShortTermCapitalGainReinvestment) onShortTermCapitalGainReinvestment();
        else if (this == SpinOff) onSpinOff();
        else if (this == Split) onSplit();
        else if (this == StockDistribution) onStockDistribution();
        else if (this == Tax) onTax();
        else if (this == TaxWithheld) onTaxWithheld();
        else if (this == Trade) onTrade();
        else if (this == Transfer) onTransfer();
        else if (this == TransferFee) onTransferFee();
        else if (this == TrustFee) onTrustFee();
        else if (this == UnqualifiedGain) onUnqualifiedGain();
        else if (this == Withdrawal) onWithdrawal();
        else otherwise(Value);
    }
}
