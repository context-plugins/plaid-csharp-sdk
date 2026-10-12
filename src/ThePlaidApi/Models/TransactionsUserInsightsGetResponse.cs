using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsUserInsightsGetResponse defines the response schema for <c>/beta/transactions/user_insights/v1/get</c>.
/// </summary>
public record TransactionsUserInsightsGetResponse
{
    /// <summary>
    /// metadata for the set of insights provided in <c>TransactionsUserInsightsGetResponse</c>
    /// </summary>
    [JsonPropertyName("user_data_overview")]
    public required UserDataOverview UserDataOverview { get; init; }

    /// <summary>
    /// Insights around a user's counterparties
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty_insights")]
    public CounterpartyInsights? CounterpartyInsights { get; init; }

    /// <summary>
    /// Insights on a user's top personal finance categories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_insights")]
    public CategoryInsights? CategoryInsights { get; init; }

    /// <summary>
    /// Insights object for recurring transactions for <c>/beta/transactions/user_insights/v1/get</c> endpoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring_transactions")]
    public RecurringTransactions? RecurringTransactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
