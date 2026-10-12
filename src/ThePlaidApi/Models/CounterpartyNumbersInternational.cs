using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Account numbers using the International Bank Account Number and BIC/SWIFT code format.
/// </summary>
public record CounterpartyNumbersInternational
{
    /// <summary>
    /// International Bank Account Number (IBAN).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [StringLength(34, MinimumLength = 15)]
    public string? Iban { get; init; }

    /// <summary>
    /// Business Identifier Code (BIC) for this counterparty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bic")]
    [StringLength(11, MinimumLength = 8)]
    public string? Bic { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
