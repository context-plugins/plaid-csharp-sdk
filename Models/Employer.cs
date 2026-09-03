using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data about the employer.
/// </summary>
public record Employer
{
    /// <summary>
    /// Plaid's unique identifier for the employer.
    /// </summary>
    [JsonPropertyName("employer_id")]
    public required string EmployerId { get; init; }

    /// <summary>
    /// The name of the employer
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Data about the components comprising an address.
    /// </summary>
    [JsonPropertyName("address")]
    public required AddressDataNullable? Address { get; init; }

    /// <summary>
    /// A number from 0 to 1 indicating Plaid's level of confidence in the pairing between the employer and the institution (not yet implemented).
    /// </summary>
    [JsonPropertyName("confidence_score")]
    public required double ConfidenceScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
