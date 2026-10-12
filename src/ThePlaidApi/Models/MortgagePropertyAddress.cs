using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing fields describing property address.
/// </summary>
public record MortgagePropertyAddress
{
    /// <summary>
    /// The city name.
    /// </summary>
    [JsonPropertyName("city")]
    public required string? City { get; init; }

    /// <summary>
    /// The ISO 3166-1 alpha-2 country code.
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// The five or nine digit postal code.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string? PostalCode { get; init; }

    /// <summary>
    /// The region or state (example "NC").
    /// </summary>
    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    /// <summary>
    /// The full street address (example "564 Main Street, Apt 15").
    /// </summary>
    [JsonPropertyName("street")]
    public required string? Street { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
