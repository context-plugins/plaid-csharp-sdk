using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// International Bank Account Number for a Wallet Transaction
/// </summary>
public record WalletTransactionCounterpartyInternational
{
    /// <summary>
    /// International Bank Account Number (IBAN).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [StringLength(34, MinimumLength = 15)]
    public string? Iban { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
