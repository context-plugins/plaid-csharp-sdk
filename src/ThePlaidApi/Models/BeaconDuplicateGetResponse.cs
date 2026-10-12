using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A Beacon Duplicate represents a pair of matching Beacon Users and an analysis of the fields they matched on.
/// </summary>
public record BeaconDuplicateGetResponse
{
    /// <summary>
    /// ID of the associated Beacon Duplicate.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A Beacon User Revision identifies a Beacon User at some point in its revision history.
    /// </summary>
    [JsonPropertyName("beacon_user1")]
    public required BeaconUserRevision BeaconUser1 { get; init; }

    /// <summary>
    /// A Beacon User Revision identifies a Beacon User at some point in its revision history.
    /// </summary>
    [JsonPropertyName("beacon_user2")]
    public required BeaconUserRevision BeaconUser2 { get; init; }

    /// <summary>
    /// Analysis of which fields matched between one Beacon User and another.
    /// </summary>
    [JsonPropertyName("analysis")]
    public required BeaconMatchSummaryAnalysis Analysis { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
