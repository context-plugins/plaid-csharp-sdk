using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An investment account. In API versions 2018-05-22 and earlier, this type is called <c>brokerage</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvestmentAccountSubtype1>))]
public sealed record InvestmentAccountSubtype1 : OpenStringEnum<InvestmentAccountSubtype1>
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
    public static readonly InvestmentAccountSubtype1 HealthReimbursementArrangement = new(
        "health reimbursement arrangement");

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

    public TResult Match<TResult>(Func<TResult> on_401A,
        Func<TResult> on_401K,
        Func<TResult> on_403B,
        Func<TResult> on_457B,
        Func<TResult> on_529,
        Func<TResult> onBrokerage,
        Func<TResult> onCashIsa,
        Func<TResult> onCryptoExchange,
        Func<TResult> onEducationSavingsAccount,
        Func<TResult> onFhsa,
        Func<TResult> onFixedAnnuity,
        Func<TResult> onGic,
        Func<TResult> onHealthReimbursementArrangement,
        Func<TResult> onHsa,
        Func<TResult> onIra,
        Func<TResult> onIsa,
        Func<TResult> onKeogh,
        Func<TResult> onLif,
        Func<TResult> onLifeInsurance,
        Func<TResult> onLineOfCredit,
        Func<TResult> onLira,
        Func<TResult> onLrif,
        Func<TResult> onLrsp,
        Func<TResult> onMutualFund,
        Func<TResult> onNonCustodialWallet,
        Func<TResult> onNonTaxableBrokerageAccount,
        Func<TResult> onOther,
        Func<TResult> onOtherAnnuity,
        Func<TResult> onOtherInsurance,
        Func<TResult> onPension,
        Func<TResult> onPrif,
        Func<TResult> onProfitSharingPlan,
        Func<TResult> onQshr,
        Func<TResult> onRdsp,
        Func<TResult> onResp,
        Func<TResult> onRetirement,
        Func<TResult> onRlif,
        Func<TResult> onRoth,
        Func<TResult> onRoth401K,
        Func<TResult> onRoth403B,
        Func<TResult> onRoth457B,
        Func<TResult> onRothPension,
        Func<TResult> onRothProfitSharingPlan,
        Func<TResult> onRothThriftSavingsPlan,
        Func<TResult> onRrif,
        Func<TResult> onRrsp,
        Func<TResult> onSarsep,
        Func<TResult> onSepIra,
        Func<TResult> onSimpleIra,
        Func<TResult> onSipp,
        Func<TResult> onStockPlan,
        Func<TResult> onTfsa,
        Func<TResult> onThriftSavingsPlan,
        Func<TResult> onTrust,
        Func<TResult> onUgma,
        Func<TResult> onUtma,
        Func<TResult> onVariableAnnuity,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _401A => on_401A(),
            _ when this == _401K => on_401K(),
            _ when this == _403B => on_403B(),
            _ when this == _457B => on_457B(),
            _ when this == _529 => on_529(),
            _ when this == Brokerage => onBrokerage(),
            _ when this == CashIsa => onCashIsa(),
            _ when this == CryptoExchange => onCryptoExchange(),
            _ when this == EducationSavingsAccount => onEducationSavingsAccount(),
            _ when this == Fhsa => onFhsa(),
            _ when this == FixedAnnuity => onFixedAnnuity(),
            _ when this == Gic => onGic(),
            _ when this == HealthReimbursementArrangement => onHealthReimbursementArrangement(),
            _ when this == Hsa => onHsa(),
            _ when this == Ira => onIra(),
            _ when this == Isa => onIsa(),
            _ when this == Keogh => onKeogh(),
            _ when this == Lif => onLif(),
            _ when this == LifeInsurance => onLifeInsurance(),
            _ when this == LineOfCredit => onLineOfCredit(),
            _ when this == Lira => onLira(),
            _ when this == Lrif => onLrif(),
            _ when this == Lrsp => onLrsp(),
            _ when this == MutualFund => onMutualFund(),
            _ when this == NonCustodialWallet => onNonCustodialWallet(),
            _ when this == NonTaxableBrokerageAccount => onNonTaxableBrokerageAccount(),
            _ when this == Other => onOther(),
            _ when this == OtherAnnuity => onOtherAnnuity(),
            _ when this == OtherInsurance => onOtherInsurance(),
            _ when this == Pension => onPension(),
            _ when this == Prif => onPrif(),
            _ when this == ProfitSharingPlan => onProfitSharingPlan(),
            _ when this == Qshr => onQshr(),
            _ when this == Rdsp => onRdsp(),
            _ when this == Resp => onResp(),
            _ when this == Retirement => onRetirement(),
            _ when this == Rlif => onRlif(),
            _ when this == Roth => onRoth(),
            _ when this == Roth401K => onRoth401K(),
            _ when this == Roth403B => onRoth403B(),
            _ when this == Roth457B => onRoth457B(),
            _ when this == RothPension => onRothPension(),
            _ when this == RothProfitSharingPlan => onRothProfitSharingPlan(),
            _ when this == RothThriftSavingsPlan => onRothThriftSavingsPlan(),
            _ when this == Rrif => onRrif(),
            _ when this == Rrsp => onRrsp(),
            _ when this == Sarsep => onSarsep(),
            _ when this == SepIra => onSepIra(),
            _ when this == SimpleIra => onSimpleIra(),
            _ when this == Sipp => onSipp(),
            _ when this == StockPlan => onStockPlan(),
            _ when this == Tfsa => onTfsa(),
            _ when this == ThriftSavingsPlan => onThriftSavingsPlan(),
            _ when this == Trust => onTrust(),
            _ when this == Ugma => onUgma(),
            _ when this == Utma => onUtma(),
            _ when this == VariableAnnuity => onVariableAnnuity(),
            _ => otherwise(Value)
        };

    public void Match(Action on_401A,
        Action on_401K,
        Action on_403B,
        Action on_457B,
        Action on_529,
        Action onBrokerage,
        Action onCashIsa,
        Action onCryptoExchange,
        Action onEducationSavingsAccount,
        Action onFhsa,
        Action onFixedAnnuity,
        Action onGic,
        Action onHealthReimbursementArrangement,
        Action onHsa,
        Action onIra,
        Action onIsa,
        Action onKeogh,
        Action onLif,
        Action onLifeInsurance,
        Action onLineOfCredit,
        Action onLira,
        Action onLrif,
        Action onLrsp,
        Action onMutualFund,
        Action onNonCustodialWallet,
        Action onNonTaxableBrokerageAccount,
        Action onOther,
        Action onOtherAnnuity,
        Action onOtherInsurance,
        Action onPension,
        Action onPrif,
        Action onProfitSharingPlan,
        Action onQshr,
        Action onRdsp,
        Action onResp,
        Action onRetirement,
        Action onRlif,
        Action onRoth,
        Action onRoth401K,
        Action onRoth403B,
        Action onRoth457B,
        Action onRothPension,
        Action onRothProfitSharingPlan,
        Action onRothThriftSavingsPlan,
        Action onRrif,
        Action onRrsp,
        Action onSarsep,
        Action onSepIra,
        Action onSimpleIra,
        Action onSipp,
        Action onStockPlan,
        Action onTfsa,
        Action onThriftSavingsPlan,
        Action onTrust,
        Action onUgma,
        Action onUtma,
        Action onVariableAnnuity,
        Action<string> otherwise)
    {
        if (this == _401A) on_401A();
        else if (this == _401K) on_401K();
        else if (this == _403B) on_403B();
        else if (this == _457B) on_457B();
        else if (this == _529) on_529();
        else if (this == Brokerage) onBrokerage();
        else if (this == CashIsa) onCashIsa();
        else if (this == CryptoExchange) onCryptoExchange();
        else if (this == EducationSavingsAccount) onEducationSavingsAccount();
        else if (this == Fhsa) onFhsa();
        else if (this == FixedAnnuity) onFixedAnnuity();
        else if (this == Gic) onGic();
        else if (this == HealthReimbursementArrangement) onHealthReimbursementArrangement();
        else if (this == Hsa) onHsa();
        else if (this == Ira) onIra();
        else if (this == Isa) onIsa();
        else if (this == Keogh) onKeogh();
        else if (this == Lif) onLif();
        else if (this == LifeInsurance) onLifeInsurance();
        else if (this == LineOfCredit) onLineOfCredit();
        else if (this == Lira) onLira();
        else if (this == Lrif) onLrif();
        else if (this == Lrsp) onLrsp();
        else if (this == MutualFund) onMutualFund();
        else if (this == NonCustodialWallet) onNonCustodialWallet();
        else if (this == NonTaxableBrokerageAccount) onNonTaxableBrokerageAccount();
        else if (this == Other) onOther();
        else if (this == OtherAnnuity) onOtherAnnuity();
        else if (this == OtherInsurance) onOtherInsurance();
        else if (this == Pension) onPension();
        else if (this == Prif) onPrif();
        else if (this == ProfitSharingPlan) onProfitSharingPlan();
        else if (this == Qshr) onQshr();
        else if (this == Rdsp) onRdsp();
        else if (this == Resp) onResp();
        else if (this == Retirement) onRetirement();
        else if (this == Rlif) onRlif();
        else if (this == Roth) onRoth();
        else if (this == Roth401K) onRoth401K();
        else if (this == Roth403B) onRoth403B();
        else if (this == Roth457B) onRoth457B();
        else if (this == RothPension) onRothPension();
        else if (this == RothProfitSharingPlan) onRothProfitSharingPlan();
        else if (this == RothThriftSavingsPlan) onRothThriftSavingsPlan();
        else if (this == Rrif) onRrif();
        else if (this == Rrsp) onRrsp();
        else if (this == Sarsep) onSarsep();
        else if (this == SepIra) onSepIra();
        else if (this == SimpleIra) onSimpleIra();
        else if (this == Sipp) onSipp();
        else if (this == StockPlan) onStockPlan();
        else if (this == Tfsa) onTfsa();
        else if (this == ThriftSavingsPlan) onThriftSavingsPlan();
        else if (this == Trust) onTrust();
        else if (this == Ugma) onUgma();
        else if (this == Utma) onUtma();
        else if (this == VariableAnnuity) onVariableAnnuity();
        else otherwise(Value);
    }
}
