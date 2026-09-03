using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Analysis information describing why a screening hit matched the provided entity information
/// </summary>
public record EntityScreeningHitAnalysis
{
    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documents")]
    public MatchSummaryCode? Documents { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_addresses")]
    public MatchSummaryCode? EmailAddresses { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locations")]
    public MatchSummaryCode? Locations { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("names")]
    public MatchSummaryCode? Names { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_numbers")]
    public MatchSummaryCode? PhoneNumbers { get; init; }

    /// <summary>
    /// An enum indicating the match type between data provided by user and data checked against an external data source.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against external data.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
    /// </para>
    /// <para>
    /// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("urls")]
    public MatchSummaryCode? Urls { get; init; }

    /// <summary>
    /// The version of the entity screening's <c>search_terms</c> that were compared when the entity screening hit was added. Entity screening hits are immutable once they have been reviewed. If changes are detected due to updates to the entity screening's <c>search_terms</c>, the associated entity program, or the list's source data prior to review, the entity screening hit will be updated to reflect those changes.
    /// </summary>
    [JsonPropertyName("search_terms_version")]
    public required int SearchTermsVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
