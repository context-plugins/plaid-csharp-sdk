using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for investment accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-investment">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvestmentAccountSubtype>))]
public sealed record InvestmentAccountSubtype : StringEnum<InvestmentAccountSubtype>
{
    private InvestmentAccountSubtype(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>529</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype _529 = new("529");

    /// <summary>
    /// The <c>401a</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype _401A = new("401a");

    /// <summary>
    /// The <c>401k</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype _401K = new("401k");

    /// <summary>
    /// The <c>403B</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype _403B = new("403B");

    /// <summary>
    /// The <c>457b</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype _457B = new("457b");

    /// <summary>
    /// The <c>brokerage</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Brokerage = new("brokerage");

    /// <summary>
    /// The <c>cash isa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype CashIsa = new("cash isa");

    /// <summary>
    /// The <c>crypto exchange</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype CryptoExchange = new("crypto exchange");

    /// <summary>
    /// The <c>education savings account</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype EducationSavingsAccount = new("education savings account");

    /// <summary>
    /// The <c>fhsa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Fhsa = new("fhsa");

    /// <summary>
    /// The <c>fixed annuity</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype FixedAnnuity = new("fixed annuity");

    /// <summary>
    /// The <c>gic</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Gic = new("gic");

    /// <summary>
    /// The <c>health reimbursement arrangement</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype HealthReimbursementArrangement = new("health reimbursement arrangement");

    /// <summary>
    /// The <c>hsa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Hsa = new("hsa");

    /// <summary>
    /// The <c>ira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Ira = new("ira");

    /// <summary>
    /// The <c>isa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Isa = new("isa");

    /// <summary>
    /// The <c>keogh</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Keogh = new("keogh");

    /// <summary>
    /// The <c>lif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Lif = new("lif");

    /// <summary>
    /// The <c>life insurance</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype LifeInsurance = new("life insurance");

    /// <summary>
    /// The <c>line of credit</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype LineOfCredit = new("line of credit");

    /// <summary>
    /// The <c>lira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Lira = new("lira");

    /// <summary>
    /// The <c>lrif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Lrif = new("lrif");

    /// <summary>
    /// The <c>lrsp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Lrsp = new("lrsp");

    /// <summary>
    /// The <c>mutual fund</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype MutualFund = new("mutual fund");

    /// <summary>
    /// The <c>non-custodial wallet</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype NonCustodialWallet = new("non-custodial wallet");

    /// <summary>
    /// The <c>non-taxable brokerage account</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype NonTaxableBrokerageAccount = new("non-taxable brokerage account");

    /// <summary>
    /// The <c>other</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Other = new("other");

    /// <summary>
    /// The <c>other annuity</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype OtherAnnuity = new("other annuity");

    /// <summary>
    /// The <c>other insurance</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype OtherInsurance = new("other insurance");

    /// <summary>
    /// The <c>pension</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Pension = new("pension");

    /// <summary>
    /// The <c>prif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Prif = new("prif");

    /// <summary>
    /// The <c>profit sharing plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype ProfitSharingPlan = new("profit sharing plan");

    /// <summary>
    /// The <c>qshr</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Qshr = new("qshr");

    /// <summary>
    /// The <c>rdsp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Rdsp = new("rdsp");

    /// <summary>
    /// The <c>resp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Resp = new("resp");

    /// <summary>
    /// The <c>retirement</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Retirement = new("retirement");

    /// <summary>
    /// The <c>rlif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Rlif = new("rlif");

    /// <summary>
    /// The <c>roth</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Roth = new("roth");

    /// <summary>
    /// The <c>roth 401k</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Roth401K = new("roth 401k");

    /// <summary>
    /// The <c>roth 403B</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Roth403B = new("roth 403B");

    /// <summary>
    /// The <c>roth 457b</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Roth457B = new("roth 457b");

    /// <summary>
    /// The <c>roth pension</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype RothPension = new("roth pension");

    /// <summary>
    /// The <c>roth profit sharing plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype RothProfitSharingPlan = new("roth profit sharing plan");

    /// <summary>
    /// The <c>roth thrift savings plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype RothThriftSavingsPlan = new("roth thrift savings plan");

    /// <summary>
    /// The <c>rrif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Rrif = new("rrif");

    /// <summary>
    /// The <c>rrsp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Rrsp = new("rrsp");

    /// <summary>
    /// The <c>sarsep</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Sarsep = new("sarsep");

    /// <summary>
    /// The <c>sep ira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype SepIra = new("sep ira");

    /// <summary>
    /// The <c>simple ira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype SimpleIra = new("simple ira");

    /// <summary>
    /// The <c>sipp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Sipp = new("sipp");

    /// <summary>
    /// The <c>stock plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype StockPlan = new("stock plan");

    /// <summary>
    /// The <c>thrift savings plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype ThriftSavingsPlan = new("thrift savings plan");

    /// <summary>
    /// The <c>tfsa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Tfsa = new("tfsa");

    /// <summary>
    /// The <c>trust</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Trust = new("trust");

    /// <summary>
    /// The <c>ugma</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Ugma = new("ugma");

    /// <summary>
    /// The <c>utma</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype Utma = new("utma");

    /// <summary>
    /// The <c>variable annuity</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype VariableAnnuity = new("variable annuity");

    /// <summary>
    /// The <c>all</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype All = new("all");

    public static InvestmentAccountSubtype FromValue(string value) => FromValueCore(value);
}
