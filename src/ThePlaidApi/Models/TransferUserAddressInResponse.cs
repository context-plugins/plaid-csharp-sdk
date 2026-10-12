using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The address associated with the account holder.
/// </summary>
public record TransferUserAddressInResponse
{
    /// <summary>
    /// The street number and name (i.e., "100 Market St.").
    /// </summary>
    [JsonPropertyName("street")]
    public required string? Street { get; init; }

    /// <summary>
    /// Ex. "San Francisco"
    /// </summary>
    [JsonPropertyName("city")]
    public required string? City { get; init; }

    /// <summary>
    /// The state or province (e.g., "CA").
    /// </summary>
    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    /// <summary>
    /// The postal code (e.g., "94103").
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string? PostalCode { get; init; }

    /// <summary>
    /// A two-letter country code (e.g., "US").
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
