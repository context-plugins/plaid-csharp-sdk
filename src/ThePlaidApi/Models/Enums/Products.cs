using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Products>))]
public sealed record Products : OpenStringEnum<Products>
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

    public TResult Match<TResult>(Func<TResult> onAssets,
        Func<TResult> onAuth,
        Func<TResult> onBalance,
        Func<TResult> onBalancePlus,
        Func<TResult> onBeacon,
        Func<TResult> onIdentity,
        Func<TResult> onIdentityMatch,
        Func<TResult> onInvestments,
        Func<TResult> onInvestmentsAuth,
        Func<TResult> onLiabilities,
        Func<TResult> onPaymentInitiation,
        Func<TResult> onIdentityVerification,
        Func<TResult> onTransactions,
        Func<TResult> onCreditDetails,
        Func<TResult> onIncome,
        Func<TResult> onIncomeVerification,
        Func<TResult> onStandingOrders,
        Func<TResult> onTransfer,
        Func<TResult> onEmployment,
        Func<TResult> onRecurringTransactions,
        Func<TResult> onTransactionsRefresh,
        Func<TResult> onSignal,
        Func<TResult> onStatements,
        Func<TResult> onProcessorPayments,
        Func<TResult> onProcessorIdentity,
        Func<TResult> onProfile,
        Func<TResult> onCraBaseReport,
        Func<TResult> onCraIncomeInsights,
        Func<TResult> onCraPartnerInsights,
        Func<TResult> onCraNetworkInsights,
        Func<TResult> onCraCashflowInsights,
        Func<TResult> onCraMonitoring,
        Func<TResult> onCraLendScore,
        Func<TResult> onCraPlaidCreditScore,
        Func<TResult> onCraQualify,
        Func<TResult> onLayer,
        Func<TResult> onPayByBank,
        Func<TResult> onProtectLinkedBank,
        Func<TResult> onProtectTransactions,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Assets => onAssets(),
            _ when this == Auth => onAuth(),
            _ when this == Balance => onBalance(),
            _ when this == BalancePlus => onBalancePlus(),
            _ when this == Beacon => onBeacon(),
            _ when this == Identity => onIdentity(),
            _ when this == IdentityMatch => onIdentityMatch(),
            _ when this == Investments => onInvestments(),
            _ when this == InvestmentsAuth => onInvestmentsAuth(),
            _ when this == Liabilities => onLiabilities(),
            _ when this == PaymentInitiation => onPaymentInitiation(),
            _ when this == IdentityVerification => onIdentityVerification(),
            _ when this == Transactions => onTransactions(),
            _ when this == CreditDetails => onCreditDetails(),
            _ when this == Income => onIncome(),
            _ when this == IncomeVerification => onIncomeVerification(),
            _ when this == StandingOrders => onStandingOrders(),
            _ when this == Transfer => onTransfer(),
            _ when this == Employment => onEmployment(),
            _ when this == RecurringTransactions => onRecurringTransactions(),
            _ when this == TransactionsRefresh => onTransactionsRefresh(),
            _ when this == Signal => onSignal(),
            _ when this == Statements => onStatements(),
            _ when this == ProcessorPayments => onProcessorPayments(),
            _ when this == ProcessorIdentity => onProcessorIdentity(),
            _ when this == Profile => onProfile(),
            _ when this == CraBaseReport => onCraBaseReport(),
            _ when this == CraIncomeInsights => onCraIncomeInsights(),
            _ when this == CraPartnerInsights => onCraPartnerInsights(),
            _ when this == CraNetworkInsights => onCraNetworkInsights(),
            _ when this == CraCashflowInsights => onCraCashflowInsights(),
            _ when this == CraMonitoring => onCraMonitoring(),
            _ when this == CraLendScore => onCraLendScore(),
            _ when this == CraPlaidCreditScore => onCraPlaidCreditScore(),
            _ when this == CraQualify => onCraQualify(),
            _ when this == Layer => onLayer(),
            _ when this == PayByBank => onPayByBank(),
            _ when this == ProtectLinkedBank => onProtectLinkedBank(),
            _ when this == ProtectTransactions => onProtectTransactions(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssets,
        Action onAuth,
        Action onBalance,
        Action onBalancePlus,
        Action onBeacon,
        Action onIdentity,
        Action onIdentityMatch,
        Action onInvestments,
        Action onInvestmentsAuth,
        Action onLiabilities,
        Action onPaymentInitiation,
        Action onIdentityVerification,
        Action onTransactions,
        Action onCreditDetails,
        Action onIncome,
        Action onIncomeVerification,
        Action onStandingOrders,
        Action onTransfer,
        Action onEmployment,
        Action onRecurringTransactions,
        Action onTransactionsRefresh,
        Action onSignal,
        Action onStatements,
        Action onProcessorPayments,
        Action onProcessorIdentity,
        Action onProfile,
        Action onCraBaseReport,
        Action onCraIncomeInsights,
        Action onCraPartnerInsights,
        Action onCraNetworkInsights,
        Action onCraCashflowInsights,
        Action onCraMonitoring,
        Action onCraLendScore,
        Action onCraPlaidCreditScore,
        Action onCraQualify,
        Action onLayer,
        Action onPayByBank,
        Action onProtectLinkedBank,
        Action onProtectTransactions,
        Action<string> otherwise)
    {
        if (this == Assets) onAssets();
        else if (this == Auth) onAuth();
        else if (this == Balance) onBalance();
        else if (this == BalancePlus) onBalancePlus();
        else if (this == Beacon) onBeacon();
        else if (this == Identity) onIdentity();
        else if (this == IdentityMatch) onIdentityMatch();
        else if (this == Investments) onInvestments();
        else if (this == InvestmentsAuth) onInvestmentsAuth();
        else if (this == Liabilities) onLiabilities();
        else if (this == PaymentInitiation) onPaymentInitiation();
        else if (this == IdentityVerification) onIdentityVerification();
        else if (this == Transactions) onTransactions();
        else if (this == CreditDetails) onCreditDetails();
        else if (this == Income) onIncome();
        else if (this == IncomeVerification) onIncomeVerification();
        else if (this == StandingOrders) onStandingOrders();
        else if (this == Transfer) onTransfer();
        else if (this == Employment) onEmployment();
        else if (this == RecurringTransactions) onRecurringTransactions();
        else if (this == TransactionsRefresh) onTransactionsRefresh();
        else if (this == Signal) onSignal();
        else if (this == Statements) onStatements();
        else if (this == ProcessorPayments) onProcessorPayments();
        else if (this == ProcessorIdentity) onProcessorIdentity();
        else if (this == Profile) onProfile();
        else if (this == CraBaseReport) onCraBaseReport();
        else if (this == CraIncomeInsights) onCraIncomeInsights();
        else if (this == CraPartnerInsights) onCraPartnerInsights();
        else if (this == CraNetworkInsights) onCraNetworkInsights();
        else if (this == CraCashflowInsights) onCraCashflowInsights();
        else if (this == CraMonitoring) onCraMonitoring();
        else if (this == CraLendScore) onCraLendScore();
        else if (this == CraPlaidCreditScore) onCraPlaidCreditScore();
        else if (this == CraQualify) onCraQualify();
        else if (this == Layer) onLayer();
        else if (this == PayByBank) onPayByBank();
        else if (this == ProtectLinkedBank) onProtectLinkedBank();
        else if (this == ProtectTransactions) onProtectTransactions();
        else otherwise(Value);
    }
}
