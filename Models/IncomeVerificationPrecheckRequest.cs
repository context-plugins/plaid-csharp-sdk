using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// IncomeVerificationPrecheckRequest defines the request schema for <c>/income/verification/precheck</c>
/// </summary>
public record IncomeVerificationPrecheckRequest
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
    /// Information about the user whose eligibility is being evaluated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public IncomeVerificationPrecheckUser? User { get; init; }

    /// <summary>
    /// Information about the end user's employer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer")]
    public IncomeVerificationPrecheckEmployer? Employer { get; init; }

    /// <summary>
    /// Information about the end user's payroll institution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payroll_institution")]
    public IncomeVerificationPrecheckPayrollInstitution? PayrollInstitution { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions_access_token")]
    public string? TransactionsAccessToken { get; init; }

    /// <summary>
    /// An array of access tokens corresponding to Items belonging to the user whose eligibility is being checked. Note that if the Items specified here are not already initialized with <c>transactions</c>, providing them in this field will cause these Items to be initialized with (and billed for) the Transactions product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions_access_tokens")]
    public IReadOnlyList<string>? TransactionsAccessTokens { get; init; }

    /// <summary>
    /// Data about military info in the income verification precheck.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("us_military_info")]
    public IncomeVerificationPrecheckMilitaryInfo? UsMilitaryInfo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
