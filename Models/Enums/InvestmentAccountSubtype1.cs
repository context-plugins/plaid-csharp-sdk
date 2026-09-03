using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An investment account. In API versions 2018-05-22 and earlier, this type is called <c>brokerage</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvestmentAccountSubtype1>))]
public sealed record InvestmentAccountSubtype1 : StringEnum<InvestmentAccountSubtype1>
{
    private InvestmentAccountSubtype1(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>401a</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 _401A = new("401a");

    /// <summary>
    /// The <c>401k</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 _401K = new("401k");

    /// <summary>
    /// The <c>403B</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 _403B = new("403B");

    /// <summary>
    /// The <c>457b</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 _457B = new("457b");

    /// <summary>
    /// The <c>529</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 _529 = new("529");

    /// <summary>
    /// The <c>brokerage</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Brokerage = new("brokerage");

    /// <summary>
    /// The <c>cash isa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 CashIsa = new("cash isa");

    /// <summary>
    /// The <c>crypto exchange</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 CryptoExchange = new("crypto exchange");

    /// <summary>
    /// The <c>education savings account</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 EducationSavingsAccount = new("education savings account");

    /// <summary>
    /// The <c>fhsa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Fhsa = new("fhsa");

    /// <summary>
    /// The <c>fixed annuity</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 FixedAnnuity = new("fixed annuity");

    /// <summary>
    /// The <c>gic</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Gic = new("gic");

    /// <summary>
    /// The <c>health reimbursement arrangement</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 HealthReimbursementArrangement = new("health reimbursement arrangement");

    /// <summary>
    /// The <c>hsa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Hsa = new("hsa");

    /// <summary>
    /// The <c>ira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Ira = new("ira");

    /// <summary>
    /// The <c>isa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Isa = new("isa");

    /// <summary>
    /// The <c>keogh</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Keogh = new("keogh");

    /// <summary>
    /// The <c>lif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Lif = new("lif");

    /// <summary>
    /// The <c>life insurance</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 LifeInsurance = new("life insurance");

    /// <summary>
    /// The <c>line of credit</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 LineOfCredit = new("line of credit");

    /// <summary>
    /// The <c>lira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Lira = new("lira");

    /// <summary>
    /// The <c>lrif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Lrif = new("lrif");

    /// <summary>
    /// The <c>lrsp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Lrsp = new("lrsp");

    /// <summary>
    /// The <c>mutual fund</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 MutualFund = new("mutual fund");

    /// <summary>
    /// The <c>non-custodial wallet</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 NonCustodialWallet = new("non-custodial wallet");

    /// <summary>
    /// The <c>non-taxable brokerage account</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 NonTaxableBrokerageAccount = new("non-taxable brokerage account");

    /// <summary>
    /// The <c>other</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Other = new("other");

    /// <summary>
    /// The <c>other annuity</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 OtherAnnuity = new("other annuity");

    /// <summary>
    /// The <c>other insurance</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 OtherInsurance = new("other insurance");

    /// <summary>
    /// The <c>pension</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Pension = new("pension");

    /// <summary>
    /// The <c>prif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Prif = new("prif");

    /// <summary>
    /// The <c>profit sharing plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 ProfitSharingPlan = new("profit sharing plan");

    /// <summary>
    /// The <c>qshr</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Qshr = new("qshr");

    /// <summary>
    /// The <c>rdsp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Rdsp = new("rdsp");

    /// <summary>
    /// The <c>resp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Resp = new("resp");

    /// <summary>
    /// The <c>retirement</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Retirement = new("retirement");

    /// <summary>
    /// The <c>rlif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Rlif = new("rlif");

    /// <summary>
    /// The <c>roth</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Roth = new("roth");

    /// <summary>
    /// The <c>roth 401k</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Roth401K = new("roth 401k");

    /// <summary>
    /// The <c>roth 403B</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Roth403B = new("roth 403B");

    /// <summary>
    /// The <c>roth 457b</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Roth457B = new("roth 457b");

    /// <summary>
    /// The <c>roth pension</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 RothPension = new("roth pension");

    /// <summary>
    /// The <c>roth profit sharing plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 RothProfitSharingPlan = new("roth profit sharing plan");

    /// <summary>
    /// The <c>roth thrift savings plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 RothThriftSavingsPlan = new("roth thrift savings plan");

    /// <summary>
    /// The <c>rrif</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Rrif = new("rrif");

    /// <summary>
    /// The <c>rrsp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Rrsp = new("rrsp");

    /// <summary>
    /// The <c>sarsep</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Sarsep = new("sarsep");

    /// <summary>
    /// The <c>sep ira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 SepIra = new("sep ira");

    /// <summary>
    /// The <c>simple ira</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 SimpleIra = new("simple ira");

    /// <summary>
    /// The <c>sipp</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Sipp = new("sipp");

    /// <summary>
    /// The <c>stock plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 StockPlan = new("stock plan");

    /// <summary>
    /// The <c>tfsa</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Tfsa = new("tfsa");

    /// <summary>
    /// The <c>thrift savings plan</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 ThriftSavingsPlan = new("thrift savings plan");

    /// <summary>
    /// The <c>trust</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Trust = new("trust");

    /// <summary>
    /// The <c>ugma</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Ugma = new("ugma");

    /// <summary>
    /// The <c>utma</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 Utma = new("utma");

    /// <summary>
    /// The <c>variable annuity</c> investment account subtype.
    /// </summary>
    public static readonly InvestmentAccountSubtype1 VariableAnnuity = new("variable annuity");

    public static InvestmentAccountSubtype1 FromValue(string value) => FromValueCore(value);
}
