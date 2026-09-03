using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A list of user-based products. User-based products include Financial Management products, Protect products, CRA products, and subscription products.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserBasedProducts>))]
public sealed record UserBasedProducts : StringEnum<UserBasedProducts>
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

    public static UserBasedProducts FromValue(string value) => FromValueCore(value);
}
