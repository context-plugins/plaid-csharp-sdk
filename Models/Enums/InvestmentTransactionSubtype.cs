using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// For descriptions of possible transaction types and subtypes, see the <see href="https://plaid.com/docs/api/accounts/#investment-transaction-types-schema">Investment transaction types schema</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvestmentTransactionSubtype>))]
public sealed record InvestmentTransactionSubtype : StringEnum<InvestmentTransactionSubtype>
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

    public static readonly InvestmentTransactionSubtype LongTermCapitalGainReinvestment = new("long-term capital gain reinvestment");

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

    public static readonly InvestmentTransactionSubtype ShortTermCapitalGainReinvestment = new("short-term capital gain reinvestment");

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

    public static InvestmentTransactionSubtype FromValue(string value) => FromValueCore(value);
}
