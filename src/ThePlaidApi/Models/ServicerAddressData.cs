using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The address of the student loan servicer. This is generally the remittance address to which payments should be sent.
/// </summary>
public record ServicerAddressData
{
    /// <summary>
    /// The full city name
    /// </summary>
    [JsonPropertyName("city")]
    public required string? City { get; init; }

    /// <summary>
    /// The region or state
    /// Example: <c>"NC"</c>
    /// </summary>
    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    /// <summary>
    /// The full street address
    /// Example: <c>"564 Main Street, APT 15"</c>
    /// </summary>
    [JsonPropertyName("street")]
    public required string? Street { get; init; }

    /// <summary>
    /// The postal code
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string? PostalCode { get; init; }

    /// <summary>
    /// The ISO 3166-1 alpha-2 country code
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
