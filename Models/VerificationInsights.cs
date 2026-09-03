using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights from performing database verification for the account. Only returned for Auth Items using Database Auth.
/// </summary>
public record VerificationInsights
{
    /// <summary>
    /// Indicates the score of the name match between the given name provided during database verification (available in the <see href="https://plaid.com/docs/api/products/auth/#auth-get-response-accounts-verification-name"><c>verification_name</c></see> field if using standard Database Auth, or provided in the request if using <c>/auth/verify</c>) and matched Plaid network accounts. If defined, will be a value between 0 and 100. Will be undefined if name matching was not enabled for the database verification session or if there were no eligible Plaid network matches to compare the given name with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name_match_score")]
    public int? NameMatchScore { get; init; }

    /// <summary>
    /// Status information about the account and routing number in the Plaid network.
    /// </summary>
    [JsonPropertyName("network_status")]
    public required VerificationInsightsNetworkStatus NetworkStatus { get; init; }

    /// <summary>
    /// Information about known ACH returns for the account and routing number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previous_returns")]
    public AccountVerificationInsightsPreviousReturns? PreviousReturns { get; init; }

    /// <summary>
    /// Indicator of account number format validity for institution.
    /// <para>
    /// <c>valid</c>: indicates that the account number has a correct format for the institution.
    /// </para>
    /// <para>
    /// <c>invalid</c>: indicates that the account number has an incorrect format for the institution.
    /// </para>
    /// <para>
    /// <c>unknown</c>: indicates that there was not enough information to determine whether the format is correct for the institution.
    /// </para>
    /// </summary>
    [JsonPropertyName("account_number_format")]
    public required VerificationInsightsAccountNumberFormat AccountNumberFormat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
