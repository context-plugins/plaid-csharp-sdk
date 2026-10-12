using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the matched direct deposit transaction used to verify a user's payroll information.
/// </summary>
public record TransactionData
{
    /// <summary>
    /// The description of the transaction.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The date of the transaction, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// A unique identifier for the end user's account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// A unique identifier for the transaction.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
