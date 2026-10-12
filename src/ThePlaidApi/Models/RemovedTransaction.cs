using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of a removed transaction
/// </summary>
public record RemovedTransaction
{
    /// <summary>
    /// The ID of the removed transaction.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// The ID of the account of the removed transaction.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
