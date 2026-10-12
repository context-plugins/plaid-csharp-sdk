using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of where a transaction took place.
/// <para>
/// Use this field to pass in structured location information you may have about your transactions. Providing location data is optional but can increase result quality. If you have unstructured location information, it may be appended to the <c>description</c> field.
/// </para>
/// </summary>
public record ClientProvidedTransactionLocation
{
    /// <summary>
    /// The country where the transaction occurred, formatted as an ISO 3166-1 alpha-2 country code ("US" or "CA").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The region or state where the transaction occurred, formatted as the official two-letter US state or Canadian province postal code, e.g. "CT" or "QC".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public string? Region { get; init; }

    /// <summary>
    /// The city where the transaction occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The street address where the transaction occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public string? Address { get; init; }

    /// <summary>
    /// The postal code where the transaction occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
