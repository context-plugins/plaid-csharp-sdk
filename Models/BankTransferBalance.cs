using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the balance of a bank transfer
/// </summary>
public record BankTransferBalance
{
    /// <summary>
    /// The total available balance - the sum of all successful debit transfer amounts minus all credit transfer amounts.
    /// </summary>
    [JsonPropertyName("available")]
    public required string Available { get; init; }

    /// <summary>
    /// The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.
    /// </summary>
    [JsonPropertyName("transactable")]
    public required string Transactable { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
