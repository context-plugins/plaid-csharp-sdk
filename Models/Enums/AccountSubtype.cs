using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountSubtype>))]
public sealed record AccountSubtype : StringEnum<AccountSubtype>
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

    public static AccountSubtype FromValue(string value) => FromValueCore(value);
}
