using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// metadata for the set of insights provided in <c>TransactionsUserInsightsGetResponse</c>
/// </summary>
public record UserDataOverview
{
    /// <summary>
    /// The total number of transactions.
    /// </summary>
    [JsonPropertyName("transaction_count")]
    public required int TransactionCount { get; init; }

    /// <summary>
    /// The date of the oldest transaction processed to generate insights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oldest_transaction_date")]
    public DateTimeOffset? OldestTransactionDate { get; init; }

    /// <summary>
    /// The date of the newest transaction processed to generate insights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newest_transaction_date")]
    public DateTimeOffset? NewestTransactionDate { get; init; }

    /// <summary>
    /// The range of days of transactions available.
    /// </summary>
    [JsonPropertyName("days_available")]
    public required int DaysAvailable { get; init; }

    /// <summary>
    /// Sum of outflow amounts.
    /// </summary>
    [JsonPropertyName("total_outflows")]
    public required double TotalOutflows { get; init; }

    /// <summary>
    /// Sum of inflow amounts.
    /// </summary>
    [JsonPropertyName("total_inflows")]
    public required double TotalInflows { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
