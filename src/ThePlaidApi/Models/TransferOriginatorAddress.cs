using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The originator's address.
/// </summary>
public record TransferOriginatorAddress
{
    /// <summary>
    /// The full city name.
    /// </summary>
    [JsonPropertyName("city")]
    public required string City { get; init; }

    /// <summary>
    /// The full street address.
    /// </summary>
    [JsonPropertyName("street")]
    public required string Street { get; init; }

    /// <summary>
    /// The two-letter code for the state or province (e.g., "CA").
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; init; }

    /// <summary>
    /// The postal code (e.g., "94103").
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; init; }

    /// <summary>
    /// ISO-3166-1 alpha-2 country code standard.
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
