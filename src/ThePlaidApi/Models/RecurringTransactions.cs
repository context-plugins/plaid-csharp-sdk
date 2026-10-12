using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights object for recurring transactions for <c>/beta/transactions/user_insights/v1/get</c> endpoint
/// </summary>
public record RecurringTransactions
{
    /// <summary>
    /// An array of inflow transaction streams (e.g., income).
    /// </summary>
    [JsonPropertyName("inflow_streams")]
    public required IReadOnlyList<RecurringInsightsStream> InflowStreams { get; init; }

    /// <summary>
    /// An array of outflow transaction streams (e.g., subscriptions, bills, loan payments).
    /// </summary>
    [JsonPropertyName("outflow_streams")]
    public required IReadOnlyList<RecurringInsightsStream> OutflowStreams { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
