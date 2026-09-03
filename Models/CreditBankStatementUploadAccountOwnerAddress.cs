using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Address on the uploaded bank statement
/// </summary>
public record CreditBankStatementUploadAccountOwnerAddress
{
    /// <summary>
    /// The full city name.
    /// </summary>
    [JsonPropertyName("city")]
    public required string? City { get; init; }

    /// <summary>
    /// The ISO 3166-1 alpha-2 country code.
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// The postal code of the address.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string? PostalCode { get; init; }

    /// <summary>
    /// The region or state.
    /// Example: <c>"NC"</c>
    /// </summary>
    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    /// <summary>
    /// The full street address.
    /// </summary>
    [JsonPropertyName("street")]
    public required string? Street { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
