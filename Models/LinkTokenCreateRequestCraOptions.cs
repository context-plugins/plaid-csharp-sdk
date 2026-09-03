using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with Plaid Check products
/// </summary>
public record LinkTokenCreateRequestCraOptions
{
    /// <summary>
    /// The number of days of history to include in Plaid Check products. Maximum is 731; minimum is 180. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Maximum(731)]
    public required int DaysRequested { get; init; }

    /// <summary>
    /// The minimum number of days of data required for the report to be successfully generated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_required")]
    [Maximum(184)]
    public int? DaysRequired { get; init; }

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Credit Partner Insights product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partner_insights")]
    public LinkTokenCreateRequestCraOptionsPartnerInsights? PartnerInsights { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Base Report product, specifically the <c>client_report_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_report")]
    public LinkTokenCreateRequestCraOptionsBaseReport? BaseReport { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Cashflow Insights product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashflow_insights")]
    public LinkTokenCreateRequestCraOptionsCashflowInsights? CashflowInsights { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the CRA LendScore product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lend_score")]
    public LinkTokenCreateRequestCraOptionsLendScore? LendScore { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the CRA Network Insights product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_insights")]
    public LinkTokenCreateRequestCraOptionsNetworkInsights? NetworkInsights { get; init; }

    /// <summary>
    /// Indicates that investment data should be extracted from the linked account(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_investments")]
    public bool? IncludeInvestments { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the CRA Income Insights product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_insights")]
    public LinkTokenCreateRequestCraOptionsIncomeInsights? IncomeInsights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
