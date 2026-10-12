using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountSubtype>))]
public sealed record AccountSubtype : OpenStringEnum<AccountSubtype>
{
    private AccountSubtype(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>401a</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype _401A = new("401a");

    /// <summary>
    /// The <c>401k</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype _401K = new("401k");

    /// <summary>
    /// The <c>403B</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype _403B = new("403B");

    /// <summary>
    /// The <c>457b</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype _457B = new("457b");

    /// <summary>
    /// The <c>529</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype _529 = new("529");

    /// <summary>
    /// The <c>auto</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Auto = new("auto");

    /// <summary>
    /// The <c>brokerage</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Brokerage = new("brokerage");

    /// <summary>
    /// The <c>business</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Business = new("business");

    /// <summary>
    /// The <c>cash isa</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype CashIsa = new("cash isa");

    /// <summary>
    /// The <c>cash management</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype CashManagement = new("cash management");

    /// <summary>
    /// The <c>cd</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Cd = new("cd");

    /// <summary>
    /// The <c>checking</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Checking = new("checking");

    /// <summary>
    /// The <c>commercial</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Commercial = new("commercial");

    /// <summary>
    /// The <c>construction</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Construction = new("construction");

    /// <summary>
    /// The <c>consumer</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Consumer = new("consumer");

    /// <summary>
    /// The <c>credit card</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype CreditCard = new("credit card");

    /// <summary>
    /// The <c>crypto exchange</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype CryptoExchange = new("crypto exchange");

    /// <summary>
    /// The <c>ebt</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Ebt = new("ebt");

    /// <summary>
    /// The <c>education savings account</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype EducationSavingsAccount = new("education savings account");

    /// <summary>
    /// The <c>fhsa</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Fhsa = new("fhsa");

    /// <summary>
    /// The <c>fixed annuity</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype FixedAnnuity = new("fixed annuity");

    /// <summary>
    /// The <c>gic</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Gic = new("gic");

    /// <summary>
    /// The <c>health reimbursement arrangement</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype HealthReimbursementArrangement = new("health reimbursement arrangement");

    /// <summary>
    /// The <c>home equity</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype HomeEquity = new("home equity");

    /// <summary>
    /// The <c>hsa</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Hsa = new("hsa");

    /// <summary>
    /// The <c>isa</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Isa = new("isa");

    /// <summary>
    /// The <c>ira</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Ira = new("ira");

    /// <summary>
    /// The <c>keogh</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Keogh = new("keogh");

    /// <summary>
    /// The <c>lif</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Lif = new("lif");

    /// <summary>
    /// The <c>life insurance</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype LifeInsurance = new("life insurance");

    /// <summary>
    /// The <c>limited purpose checking</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype LimitedPurposeChecking = new("limited purpose checking");

    /// <summary>
    /// The <c>line of credit</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype LineOfCredit = new("line of credit");

    /// <summary>
    /// The <c>lira</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Lira = new("lira");

    /// <summary>
    /// The <c>loan</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Loan = new("loan");

    /// <summary>
    /// The <c>lrif</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Lrif = new("lrif");

    /// <summary>
    /// The <c>lrsp</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Lrsp = new("lrsp");

    /// <summary>
    /// The <c>money market</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype MoneyMarket = new("money market");

    /// <summary>
    /// The <c>mortgage</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Mortgage = new("mortgage");

    /// <summary>
    /// The <c>mutual fund</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype MutualFund = new("mutual fund");

    /// <summary>
    /// The <c>non-custodial wallet</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype NonCustodialWallet = new("non-custodial wallet");

    /// <summary>
    /// The <c>non-taxable brokerage account</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype NonTaxableBrokerageAccount = new("non-taxable brokerage account");

    /// <summary>
    /// The <c>other</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Other = new("other");

    /// <summary>
    /// The <c>other insurance</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype OtherInsurance = new("other insurance");

    /// <summary>
    /// The <c>other annuity</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype OtherAnnuity = new("other annuity");

    /// <summary>
    /// The <c>overdraft</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Overdraft = new("overdraft");

    /// <summary>
    /// The <c>paypal</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Paypal = new("paypal");

    /// <summary>
    /// The <c>payroll</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Payroll = new("payroll");

    /// <summary>
    /// The <c>pension</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Pension = new("pension");

    /// <summary>
    /// The <c>prepaid</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Prepaid = new("prepaid");

    /// <summary>
    /// The <c>prif</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Prif = new("prif");

    /// <summary>
    /// The <c>profit sharing plan</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype ProfitSharingPlan = new("profit sharing plan");

    /// <summary>
    /// The <c>qshr</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Qshr = new("qshr");

    /// <summary>
    /// The <c>rdsp</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Rdsp = new("rdsp");

    /// <summary>
    /// The <c>resp</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Resp = new("resp");

    /// <summary>
    /// The <c>retirement</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Retirement = new("retirement");

    /// <summary>
    /// The <c>rlif</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Rlif = new("rlif");

    /// <summary>
    /// The <c>roth</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Roth = new("roth");

    /// <summary>
    /// The <c>roth 401k</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Roth401K = new("roth 401k");

    /// <summary>
    /// The <c>roth 403B</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Roth403B = new("roth 403B");

    /// <summary>
    /// The <c>roth 457b</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Roth457B = new("roth 457b");

    /// <summary>
    /// The <c>roth pension</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype RothPension = new("roth pension");

    /// <summary>
    /// The <c>roth profit sharing plan</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype RothProfitSharingPlan = new("roth profit sharing plan");

    /// <summary>
    /// The <c>roth thrift savings plan</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype RothThriftSavingsPlan = new("roth thrift savings plan");

    /// <summary>
    /// The <c>rrif</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Rrif = new("rrif");

    /// <summary>
    /// The <c>rrsp</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Rrsp = new("rrsp");

    /// <summary>
    /// The <c>sarsep</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Sarsep = new("sarsep");

    /// <summary>
    /// The <c>savings</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Savings = new("savings");

    /// <summary>
    /// The <c>sep ira</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype SepIra = new("sep ira");

    /// <summary>
    /// The <c>simple ira</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype SimpleIra = new("simple ira");

    /// <summary>
    /// The <c>sipp</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Sipp = new("sipp");

    /// <summary>
    /// The <c>stock plan</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype StockPlan = new("stock plan");

    /// <summary>
    /// The <c>student</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Student = new("student");

    /// <summary>
    /// The <c>thrift savings plan</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype ThriftSavingsPlan = new("thrift savings plan");

    /// <summary>
    /// The <c>tfsa</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Tfsa = new("tfsa");

    /// <summary>
    /// The <c>trust</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Trust = new("trust");

    /// <summary>
    /// The <c>ugma</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Ugma = new("ugma");

    /// <summary>
    /// The <c>utma</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype Utma = new("utma");

    /// <summary>
    /// The <c>variable annuity</c> account subtype.
    /// </summary>
    public static readonly AccountSubtype VariableAnnuity = new("variable annuity");

    public TResult Match<TResult>(Func<TResult> on_401A,
        Func<TResult> on_401K,
        Func<TResult> on_403B,
        Func<TResult> on_457B,
        Func<TResult> on_529,
        Func<TResult> onAuto,
        Func<TResult> onBrokerage,
        Func<TResult> onBusiness,
        Func<TResult> onCashIsa,
        Func<TResult> onCashManagement,
        Func<TResult> onCd,
        Func<TResult> onChecking,
        Func<TResult> onCommercial,
        Func<TResult> onConstruction,
        Func<TResult> onConsumer,
        Func<TResult> onCreditCard,
        Func<TResult> onCryptoExchange,
        Func<TResult> onEbt,
        Func<TResult> onEducationSavingsAccount,
        Func<TResult> onFhsa,
        Func<TResult> onFixedAnnuity,
        Func<TResult> onGic,
        Func<TResult> onHealthReimbursementArrangement,
        Func<TResult> onHomeEquity,
        Func<TResult> onHsa,
        Func<TResult> onIsa,
        Func<TResult> onIra,
        Func<TResult> onKeogh,
        Func<TResult> onLif,
        Func<TResult> onLifeInsurance,
        Func<TResult> onLimitedPurposeChecking,
        Func<TResult> onLineOfCredit,
        Func<TResult> onLira,
        Func<TResult> onLoan,
        Func<TResult> onLrif,
        Func<TResult> onLrsp,
        Func<TResult> onMoneyMarket,
        Func<TResult> onMortgage,
        Func<TResult> onMutualFund,
        Func<TResult> onNonCustodialWallet,
        Func<TResult> onNonTaxableBrokerageAccount,
        Func<TResult> onOther,
        Func<TResult> onOtherInsurance,
        Func<TResult> onOtherAnnuity,
        Func<TResult> onOverdraft,
        Func<TResult> onPaypal,
        Func<TResult> onPayroll,
        Func<TResult> onPension,
        Func<TResult> onPrepaid,
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
        Func<TResult> onSavings,
        Func<TResult> onSepIra,
        Func<TResult> onSimpleIra,
        Func<TResult> onSipp,
        Func<TResult> onStockPlan,
        Func<TResult> onStudent,
        Func<TResult> onThriftSavingsPlan,
        Func<TResult> onTfsa,
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
            _ when this == Auto => onAuto(),
            _ when this == Brokerage => onBrokerage(),
            _ when this == Business => onBusiness(),
            _ when this == CashIsa => onCashIsa(),
            _ when this == CashManagement => onCashManagement(),
            _ when this == Cd => onCd(),
            _ when this == Checking => onChecking(),
            _ when this == Commercial => onCommercial(),
            _ when this == Construction => onConstruction(),
            _ when this == Consumer => onConsumer(),
            _ when this == CreditCard => onCreditCard(),
            _ when this == CryptoExchange => onCryptoExchange(),
            _ when this == Ebt => onEbt(),
            _ when this == EducationSavingsAccount => onEducationSavingsAccount(),
            _ when this == Fhsa => onFhsa(),
            _ when this == FixedAnnuity => onFixedAnnuity(),
            _ when this == Gic => onGic(),
            _ when this == HealthReimbursementArrangement => onHealthReimbursementArrangement(),
            _ when this == HomeEquity => onHomeEquity(),
            _ when this == Hsa => onHsa(),
            _ when this == Isa => onIsa(),
            _ when this == Ira => onIra(),
            _ when this == Keogh => onKeogh(),
            _ when this == Lif => onLif(),
            _ when this == LifeInsurance => onLifeInsurance(),
            _ when this == LimitedPurposeChecking => onLimitedPurposeChecking(),
            _ when this == LineOfCredit => onLineOfCredit(),
            _ when this == Lira => onLira(),
            _ when this == Loan => onLoan(),
            _ when this == Lrif => onLrif(),
            _ when this == Lrsp => onLrsp(),
            _ when this == MoneyMarket => onMoneyMarket(),
            _ when this == Mortgage => onMortgage(),
            _ when this == MutualFund => onMutualFund(),
            _ when this == NonCustodialWallet => onNonCustodialWallet(),
            _ when this == NonTaxableBrokerageAccount => onNonTaxableBrokerageAccount(),
            _ when this == Other => onOther(),
            _ when this == OtherInsurance => onOtherInsurance(),
            _ when this == OtherAnnuity => onOtherAnnuity(),
            _ when this == Overdraft => onOverdraft(),
            _ when this == Paypal => onPaypal(),
            _ when this == Payroll => onPayroll(),
            _ when this == Pension => onPension(),
            _ when this == Prepaid => onPrepaid(),
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
            _ when this == Savings => onSavings(),
            _ when this == SepIra => onSepIra(),
            _ when this == SimpleIra => onSimpleIra(),
            _ when this == Sipp => onSipp(),
            _ when this == StockPlan => onStockPlan(),
            _ when this == Student => onStudent(),
            _ when this == ThriftSavingsPlan => onThriftSavingsPlan(),
            _ when this == Tfsa => onTfsa(),
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
        Action onAuto,
        Action onBrokerage,
        Action onBusiness,
        Action onCashIsa,
        Action onCashManagement,
        Action onCd,
        Action onChecking,
        Action onCommercial,
        Action onConstruction,
        Action onConsumer,
        Action onCreditCard,
        Action onCryptoExchange,
        Action onEbt,
        Action onEducationSavingsAccount,
        Action onFhsa,
        Action onFixedAnnuity,
        Action onGic,
        Action onHealthReimbursementArrangement,
        Action onHomeEquity,
        Action onHsa,
        Action onIsa,
        Action onIra,
        Action onKeogh,
        Action onLif,
        Action onLifeInsurance,
        Action onLimitedPurposeChecking,
        Action onLineOfCredit,
        Action onLira,
        Action onLoan,
        Action onLrif,
        Action onLrsp,
        Action onMoneyMarket,
        Action onMortgage,
        Action onMutualFund,
        Action onNonCustodialWallet,
        Action onNonTaxableBrokerageAccount,
        Action onOther,
        Action onOtherInsurance,
        Action onOtherAnnuity,
        Action onOverdraft,
        Action onPaypal,
        Action onPayroll,
        Action onPension,
        Action onPrepaid,
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
        Action onSavings,
        Action onSepIra,
        Action onSimpleIra,
        Action onSipp,
        Action onStockPlan,
        Action onStudent,
        Action onThriftSavingsPlan,
        Action onTfsa,
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
        else if (this == Auto) onAuto();
        else if (this == Brokerage) onBrokerage();
        else if (this == Business) onBusiness();
        else if (this == CashIsa) onCashIsa();
        else if (this == CashManagement) onCashManagement();
        else if (this == Cd) onCd();
        else if (this == Checking) onChecking();
        else if (this == Commercial) onCommercial();
        else if (this == Construction) onConstruction();
        else if (this == Consumer) onConsumer();
        else if (this == CreditCard) onCreditCard();
        else if (this == CryptoExchange) onCryptoExchange();
        else if (this == Ebt) onEbt();
        else if (this == EducationSavingsAccount) onEducationSavingsAccount();
        else if (this == Fhsa) onFhsa();
        else if (this == FixedAnnuity) onFixedAnnuity();
        else if (this == Gic) onGic();
        else if (this == HealthReimbursementArrangement) onHealthReimbursementArrangement();
        else if (this == HomeEquity) onHomeEquity();
        else if (this == Hsa) onHsa();
        else if (this == Isa) onIsa();
        else if (this == Ira) onIra();
        else if (this == Keogh) onKeogh();
        else if (this == Lif) onLif();
        else if (this == LifeInsurance) onLifeInsurance();
        else if (this == LimitedPurposeChecking) onLimitedPurposeChecking();
        else if (this == LineOfCredit) onLineOfCredit();
        else if (this == Lira) onLira();
        else if (this == Loan) onLoan();
        else if (this == Lrif) onLrif();
        else if (this == Lrsp) onLrsp();
        else if (this == MoneyMarket) onMoneyMarket();
        else if (this == Mortgage) onMortgage();
        else if (this == MutualFund) onMutualFund();
        else if (this == NonCustodialWallet) onNonCustodialWallet();
        else if (this == NonTaxableBrokerageAccount) onNonTaxableBrokerageAccount();
        else if (this == Other) onOther();
        else if (this == OtherInsurance) onOtherInsurance();
        else if (this == OtherAnnuity) onOtherAnnuity();
        else if (this == Overdraft) onOverdraft();
        else if (this == Paypal) onPaypal();
        else if (this == Payroll) onPayroll();
        else if (this == Pension) onPension();
        else if (this == Prepaid) onPrepaid();
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
        else if (this == Savings) onSavings();
        else if (this == SepIra) onSepIra();
        else if (this == SimpleIra) onSimpleIra();
        else if (this == Sipp) onSipp();
        else if (this == StockPlan) onStockPlan();
        else if (this == Student) onStudent();
        else if (this == ThriftSavingsPlan) onThriftSavingsPlan();
        else if (this == Tfsa) onTfsa();
        else if (this == Trust) onTrust();
        else if (this == Ugma) onUgma();
        else if (this == Utma) onUtma();
        else if (this == VariableAnnuity) onVariableAnnuity();
        else otherwise(Value);
    }
}
