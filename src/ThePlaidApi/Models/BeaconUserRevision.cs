using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A Beacon User Revision identifies a Beacon User at some point in its revision history.
/// </summary>
public record BeaconUserRevision
{
    /// <summary>
    /// ID of the associated Beacon User.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The <c>version</c> field begins with 1 and increments with each subsequent revision.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
