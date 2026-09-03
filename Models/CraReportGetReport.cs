using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The CRA report returned by <c>/cra/report/get</c>.
/// </summary>
public record CraReportGetReport
{
    /// <summary>
    /// The date and time the report was retrieved.
    /// </summary>
    [JsonPropertyName("retrieved_time")]
    public required DateTimeOffset RetrievedTime { get; init; }

    /// <summary>
    /// Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.
    /// </summary>
    [JsonPropertyName("scope")]
    public required CraReportScope Scope { get; init; }

    /// <summary>
    /// The stage in the lending lifecycle for which the report is being retrieved.
    /// </summary>
    [JsonPropertyName("decision_stage")]
    public required CraReportDecisionStage DecisionStage { get; init; }

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
    /// Per-product report data. Each entry corresponds to one requested product.
    /// </summary>
    [JsonPropertyName("products")]
    public required IReadOnlyList<CraReportGetResponseProduct> Products { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
