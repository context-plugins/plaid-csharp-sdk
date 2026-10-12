using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Summary of how a specific business field matched against data provider results
/// </summary>
public record BusinessFieldMatchSummary
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
    [JsonPropertyName("summary")]
    public required MatchSummaryCode Summary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
