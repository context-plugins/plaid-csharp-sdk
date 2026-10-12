using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A possible account detected to be associated with a transaction user.
/// </summary>
public record DetectedAccount
{
    /// <summary>
    /// The detected account type (depository, credit, loan, investment etc.).
    /// </summary>
    [JsonPropertyName("account_type")]
    public required string? AccountType { get; init; }

    /// <summary>
    /// The detected subtype of the account, based on the transactions to/from the institution.
    /// </summary>
    [JsonPropertyName("account_subtype")]
    public required string? AccountSubtype { get; init; }

    /// <summary>
    /// The number of transactions associated with this detected account type at this financial institution.
    /// </summary>
    [JsonPropertyName("transaction_count")]
    public required int TransactionCount { get; init; }

    /// <summary>
    /// The date of the oldest transaction associated with this detected account type at this financial institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oldest_transaction_date")]
    public DateTimeOffset? OldestTransactionDate { get; init; }

    /// <summary>
    /// The date of the newest transaction associated with this detected account type at this financial institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newest_transaction_date")]
    public DateTimeOffset? NewestTransactionDate { get; init; }

    /// <summary>
    /// Amount of the most recent transaction associated with this detected account type at this financial institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newest_transaction_amount")]
    public double? NewestTransactionAmount { get; init; }

    /// <summary>
    /// Sum of outflow amounts associated with this detected account type at this financial institution.
    /// </summary>
    [JsonPropertyName("total_outflows")]
    public required double TotalOutflows { get; init; }

    /// <summary>
    /// Sum of inflow amounts associated with this detected account type at this financial institution.
    /// </summary>
    [JsonPropertyName("total_inflows")]
    public required double TotalInflows { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
