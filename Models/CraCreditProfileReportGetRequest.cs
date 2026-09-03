using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCreditProfileReportGetRequest defines the request schema for <c>/cra/credit_profile/report/get</c>.
/// </summary>
public record CraCreditProfileReportGetRequest
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
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

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

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonPropertyName("client_report_id")]
    public required string ClientReportId { get; init; }

    /// <summary>
    /// The product type for the credit profile report request.
    /// </summary>
    [JsonPropertyName("report_type")]
    public string ReportType { get; } = "QUALIFY";

    /// <summary>
    /// The inquiry type of credit profile report.
    /// </summary>
    [JsonPropertyName("inquiry_type")]
    public required CraCreditProfileInquiryType InquiryType { get; init; }

    /// <summary>
    /// The version of the credit profile report to retrieve.
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; } = "v1";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
