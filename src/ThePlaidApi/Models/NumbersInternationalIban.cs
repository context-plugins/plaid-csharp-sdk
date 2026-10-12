using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Account numbers using the International Bank Account Number and BIC/SWIFT code format.
/// </summary>
public record NumbersInternationalIban
{
    /// <summary>
    /// International Bank Account Number (IBAN).
    /// </summary>
    [JsonPropertyName("iban")]
    [StringLength(34, MinimumLength = 15)]
    public required string Iban { get; init; }

    /// <summary>
    /// The Business Identifier Code, also known as SWIFT code, for this bank account.
    /// </summary>
    [JsonPropertyName("bic")]
    [StringLength(11, MinimumLength = 8)]
    public required string Bic { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
