using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of details related to a fulfillment service or product in terms of request, process and result.
/// </summary>
public record CreditFreddieMacService
{
    [JsonPropertyName("VERIFICATION_OF_ASSET")]
    public required IReadOnlyList<CreditFreddieMacVerificationOfAsset> VerificationOfAsset { get; init; }

    /// <summary>
    /// A collection of STATUS containers.
    /// </summary>
    [JsonPropertyName("STATUSES")]
    public required Statuses Statuses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
