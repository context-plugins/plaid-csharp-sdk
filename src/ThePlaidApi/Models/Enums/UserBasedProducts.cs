using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A list of user-based products. User-based products include Financial Management products, Protect products, CRA products, and subscription products.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserBasedProducts>))]
public sealed record UserBasedProducts : OpenStringEnum<UserBasedProducts>
{
    private UserBasedProducts(string value) : base(value)
    {
    }

    public static readonly UserBasedProducts CraBaseReport = new("cra_base_report");

    public static readonly UserBasedProducts CraIncomeInsights = new("cra_income_insights");

    public static readonly UserBasedProducts CraPartnerInsights = new("cra_partner_insights");

    public static readonly UserBasedProducts CraNetworkInsights = new("cra_network_insights");

    public static readonly UserBasedProducts CraCashflowInsights = new("cra_cashflow_insights");

    public static readonly UserBasedProducts CraMonitoring = new("cra_monitoring");

    public static readonly UserBasedProducts CraLendScore = new("cra_lend_score");

    public static readonly UserBasedProducts CraPlaidCreditScore = new("cra_plaid_credit_score");

    public static readonly UserBasedProducts Investments = new("investments");

    public static readonly UserBasedProducts Liabilities = new("liabilities");

    public static readonly UserBasedProducts ProtectLinkedBank = new("protect_linked_bank");

    public static readonly UserBasedProducts ProtectTransactions = new("protect_transactions");

    public static readonly UserBasedProducts Transactions = new("transactions");

    public TResult Match<TResult>(Func<TResult> onCraBaseReport,
        Func<TResult> onCraIncomeInsights,
        Func<TResult> onCraPartnerInsights,
        Func<TResult> onCraNetworkInsights,
        Func<TResult> onCraCashflowInsights,
        Func<TResult> onCraMonitoring,
        Func<TResult> onCraLendScore,
        Func<TResult> onCraPlaidCreditScore,
        Func<TResult> onInvestments,
        Func<TResult> onLiabilities,
        Func<TResult> onProtectLinkedBank,
        Func<TResult> onProtectTransactions,
        Func<TResult> onTransactions,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CraBaseReport => onCraBaseReport(),
            _ when this == CraIncomeInsights => onCraIncomeInsights(),
            _ when this == CraPartnerInsights => onCraPartnerInsights(),
            _ when this == CraNetworkInsights => onCraNetworkInsights(),
            _ when this == CraCashflowInsights => onCraCashflowInsights(),
            _ when this == CraMonitoring => onCraMonitoring(),
            _ when this == CraLendScore => onCraLendScore(),
            _ when this == CraPlaidCreditScore => onCraPlaidCreditScore(),
            _ when this == Investments => onInvestments(),
            _ when this == Liabilities => onLiabilities(),
            _ when this == ProtectLinkedBank => onProtectLinkedBank(),
            _ when this == ProtectTransactions => onProtectTransactions(),
            _ when this == Transactions => onTransactions(),
            _ => otherwise(Value)
        };

    public void Match(Action onCraBaseReport,
        Action onCraIncomeInsights,
        Action onCraPartnerInsights,
        Action onCraNetworkInsights,
        Action onCraCashflowInsights,
        Action onCraMonitoring,
        Action onCraLendScore,
        Action onCraPlaidCreditScore,
        Action onInvestments,
        Action onLiabilities,
        Action onProtectLinkedBank,
        Action onProtectTransactions,
        Action onTransactions,
        Action<string> otherwise)
    {
        if (this == CraBaseReport) onCraBaseReport();
        else if (this == CraIncomeInsights) onCraIncomeInsights();
        else if (this == CraPartnerInsights) onCraPartnerInsights();
        else if (this == CraNetworkInsights) onCraNetworkInsights();
        else if (this == CraCashflowInsights) onCraCashflowInsights();
        else if (this == CraMonitoring) onCraMonitoring();
        else if (this == CraLendScore) onCraLendScore();
        else if (this == CraPlaidCreditScore) onCraPlaidCreditScore();
        else if (this == Investments) onInvestments();
        else if (this == Liabilities) onLiabilities();
        else if (this == ProtectLinkedBank) onProtectLinkedBank();
        else if (this == ProtectTransactions) onProtectTransactions();
        else if (this == Transactions) onTransactions();
        else otherwise(Value);
    }
}
