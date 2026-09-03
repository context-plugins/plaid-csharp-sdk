using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Products>))]
public sealed record Products : StringEnum<Products>
{
    private Products(string value) : base(value)
    {
    }

    public static readonly Products Assets = new("assets");

    public static readonly Products Auth = new("auth");

    public static readonly Products Balance = new("balance");

    public static readonly Products BalancePlus = new("balance_plus");

    public static readonly Products Beacon = new("beacon");

    public static readonly Products Identity = new("identity");

    public static readonly Products IdentityMatch = new("identity_match");

    public static readonly Products Investments = new("investments");

    public static readonly Products InvestmentsAuth = new("investments_auth");

    public static readonly Products Liabilities = new("liabilities");

    public static readonly Products PaymentInitiation = new("payment_initiation");

    public static readonly Products IdentityVerification = new("identity_verification");

    public static readonly Products Transactions = new("transactions");

    public static readonly Products CreditDetails = new("credit_details");

    public static readonly Products Income = new("income");

    public static readonly Products IncomeVerification = new("income_verification");

    public static readonly Products StandingOrders = new("standing_orders");

    public static readonly Products Transfer = new("transfer");

    public static readonly Products Employment = new("employment");

    public static readonly Products RecurringTransactions = new("recurring_transactions");

    public static readonly Products TransactionsRefresh = new("transactions_refresh");

    public static readonly Products Signal = new("signal");

    public static readonly Products Statements = new("statements");

    public static readonly Products ProcessorPayments = new("processor_payments");

    public static readonly Products ProcessorIdentity = new("processor_identity");

    public static readonly Products Profile = new("profile");

    public static readonly Products CraBaseReport = new("cra_base_report");

    public static readonly Products CraIncomeInsights = new("cra_income_insights");

    public static readonly Products CraPartnerInsights = new("cra_partner_insights");

    public static readonly Products CraNetworkInsights = new("cra_network_insights");

    public static readonly Products CraCashflowInsights = new("cra_cashflow_insights");

    public static readonly Products CraMonitoring = new("cra_monitoring");

    public static readonly Products CraLendScore = new("cra_lend_score");

    public static readonly Products CraPlaidCreditScore = new("cra_plaid_credit_score");

    public static readonly Products CraQualify = new("cra_qualify");

    public static readonly Products Layer = new("layer");

    public static readonly Products PayByBank = new("pay_by_bank");

    public static readonly Products ProtectLinkedBank = new("protect_linked_bank");

    public static readonly Products ProtectTransactions = new("protect_transactions");

    public static Products FromValue(string value) => FromValueCore(value);
}
