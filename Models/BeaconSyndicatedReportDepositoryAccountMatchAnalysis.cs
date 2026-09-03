using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Analysis of whether this account matched between the originally reported Beacon User and the Beacon User that the report syndicated to.
/// </summary>
public record BeaconSyndicatedReportDepositoryAccountMatchAnalysis
{
    /// <summary>
    /// The last 2-4 numeric characters of this account's account number.
    /// </summary>
    [JsonPropertyName("account_mask")]
    public required string AccountMask { get; init; }

    /// <summary>
    /// The routing number of the account.
    /// </summary>
    [JsonPropertyName("routing_number")]
    public required string RoutingNumber { get; init; }

    /// <summary>
    /// An enum indicating the match type between two Beacon Users.
    /// <para>
    ///
    /// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
    /// </para>
    /// <para>
    /// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
    /// </para>
    /// </summary>
    [JsonPropertyName("match_status")]
    public required BeaconMatchSummaryCode MatchStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
