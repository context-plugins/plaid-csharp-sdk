using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of where a transaction took place. Location data is provided only for transactions at physical locations, not for online transactions. Location data availability depends primarily on the merchant and is most likely to be populated for transactions at large retail chains; small, local businesses are less likely to have location data available.
/// </summary>
public record TransactionLocation
{
    /// <summary>
    /// The street address where the transaction occurred.
    /// </summary>
    [JsonPropertyName("address")]
    public required string? Address { get; init; }

    /// <summary>
    /// The city where the transaction occurred.
    /// </summary>
    [JsonPropertyName("city")]
    public required string? City { get; init; }

    /// <summary>
    /// The region or state where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called <c>state</c>.
    /// </summary>
    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    /// <summary>
    /// The postal code where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called <c>zip</c>.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string? PostalCode { get; init; }

    /// <summary>
    /// The ISO 3166-1 alpha-2 country code where the transaction occurred.
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// The latitude where the transaction occurred.
    /// </summary>
    [JsonPropertyName("lat")]
    public required double? Lat { get; init; }

    /// <summary>
    /// The longitude where the transaction occurred.
    /// </summary>
    [JsonPropertyName("lon")]
    public required double? Lon { get; init; }

    /// <summary>
    /// The merchant defined store number where the transaction occurred.
    /// </summary>
    [JsonPropertyName("store_number")]
    public required string? StoreNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
