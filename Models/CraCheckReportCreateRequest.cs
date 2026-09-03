using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCheckReportCreateRequest defines the request schema for <c>/cra/check_report/create</c>.
/// </summary>
public record CraCheckReportCreateRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// The user token associated with the user for which data is being requested. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_token")]
    public string? UserToken { get; init; }

    /// <summary>
    /// The destination URL to which webhooks will be sent
    /// </summary>
    [JsonPropertyName("webhook")]
    public required string Webhook { get; init; }

    /// <summary>
    /// The number of days of data to request for the report. Default value is 365; maximum is 731; minimum is 180. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.
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
    /// Specifies a list of products to generate when creating the report (in addition to the Base Report, which is always generated). These products will be made available before a success webhook is sent. Note that specifying <c>cra_partner_insights</c> in this field will trigger a billable event. Other products are not billed until the respective reports are retrieved via their product-specific <c>/get</c> endpoints.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("products")]
    [MinLength(1)]
    public IReadOnlyList<Products?>? Products { get; init; }

    /// <summary>
    /// Defines configuration options to generate a Base Report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_report")]
    public CraCheckReportCreateBaseReportOptions? BaseReport { get; init; }

    /// <summary>
    /// Defines configuration options to generate Cashflow Insights
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashflow_insights")]
    public CraCheckReportCreateCashflowInsightsOptions? CashflowInsights { get; init; }

    /// <summary>
    /// Defines configuration to generate Partner Insights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partner_insights")]
    public CraCheckReportCreatePartnerInsightsOptions? PartnerInsights { get; init; }

    /// <summary>
    /// Defines configuration options to generate the LendScore
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lend_score")]
    public CraCheckReportCreateLendScoreOptions? LendScore { get; init; }

    /// <summary>
    /// Defines configuration options to generate Network Insights
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_insights")]
    public CraCheckReportCreateNetworkInsightsOptions? NetworkInsights { get; init; }

    /// <summary>
    /// Indicates that investment data should be extracted from the linked account(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_investments")]
    public bool? IncludeInvestments { get; init; }

    /// <summary>
    /// Defines configuration options to generate Income Insights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_insights")]
    public CraCheckReportCreateIncomeInsightsOptions? IncomeInsights { get; init; }

    /// <summary>
    /// Describes the reason you are generating a Consumer Report for this user. When calling <c>/link/token/create</c>, this field is required when using Plaid Check (CRA) products; invalid if not using Plaid Check (CRA) products.
    /// <para>
    /// <c>ACCOUNT_REVIEW_CREDIT</c>: In connection with a consumer credit transaction for the review or collection of an account pursuant to FCRA Section 604(a)(3)(A).
    /// </para>
    /// <para>
    /// <c>ACCOUNT_REVIEW_NON_CREDIT</c>: For a legitimate business need of the information to review a non-credit account provided primarily for personal, family, or household purposes to determine whether the consumer continues to meet the terms of the account pursuant to FCRA Section 604(a)(3)(F)(2).
    /// </para>
    /// <para>
    /// <c>EXTENSION_OF_CREDIT</c>: In connection with a credit transaction initiated by and involving the consumer pursuant to FCRA Section 604(a)(3)(A).
    /// </para>
    /// <para>
    /// <c>LEGITIMATE_BUSINESS_NEED_TENANT_SCREENING</c>: For a legitimate business need in connection with a business transaction initiated by the consumer primarily for personal, family, or household purposes in connection with a property rental assessment pursuant to FCRA Section 604(a)(3)(F)(i).
    /// </para>
    /// <para>
    /// <c>LEGITIMATE_BUSINESS_NEED_OTHER</c>: For a legitimate business need in connection with a business transaction made primarily for personal, family, or household initiated by the consumer pursuant to FCRA Section 604(a)(3)(F)(i).
    /// </para>
    /// <para>
    /// <c>WRITTEN_INSTRUCTION_PREQUALIFICATION</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), to evaluate an application's profile to make an offer to the consumer.
    /// </para>
    /// <para>
    /// <c>WRITTEN_INSTRUCTION_OTHER</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), such as when an individual agrees to act as a guarantor or assumes personal liability for a consumer, business, or commercial loan.
    /// </para>
    /// <para>
    /// <c>ELIGIBILITY_FOR_GOVT_BENEFITS</c>:  In connection with an eligibility determination for a government benefit where the entity is required to consider an applicant's financial status pursuant to FCRA Section 604(a)(3)(D).
    /// </para>
    /// </summary>
    [JsonPropertyName("consumer_report_permissible_purpose")]
    public required ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
