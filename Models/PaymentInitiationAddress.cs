using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.
/// </summary>
public record PaymentInitiationAddress
{
    /// <summary>
    /// An array of length 1-2 representing the street address where the recipient is located. Maximum of 70 characters.
    /// </summary>
    [JsonPropertyName("street")]
    [MinLength(1)]
    public required IReadOnlyList<string> Street { get; init; }

    /// <summary>
    /// The city where the recipient is located. Maximum of 35 characters.
    /// </summary>
    [JsonPropertyName("city")]
    [StringLength(35, MinimumLength = 1)]
    public required string City { get; init; }

    /// <summary>
    /// The postal code where the recipient is located. Maximum of 16 characters.
    /// </summary>
    [JsonPropertyName("postal_code")]
    [StringLength(16, MinimumLength = 1)]
    public required string PostalCode { get; init; }

    /// <summary>
    /// The ISO 3166-1 alpha-2 country code where the recipient is located.
    /// </summary>
    [JsonPropertyName("country")]
    [StringLength(2, MinimumLength = 2)]
    public required string Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
