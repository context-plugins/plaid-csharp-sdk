using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of details related to a fulfillment service or product in terms of request, process and result.
/// </summary>
public record Service
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("VERIFICATION_OF_ASSET")]
    public required VerificationOfAsset VerificationOfAsset { get; init; }

    /// <summary>
    /// A collection of STATUS containers.
    /// </summary>
    [JsonPropertyName("STATUSES")]
    public required Statuses Statuses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
