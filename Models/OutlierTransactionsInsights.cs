using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights into unusually large transactions that exceed typical spending patterns for the account.
/// </summary>
public record OutlierTransactionsInsights
{
    /// <summary>
    /// The total number of transactions whose value is above the threshold of normal amounts for a given account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions_count")]
    public int? TransactionsCount { get; init; }

    /// <summary>
    /// A monetary amount with its associated currency information, supporting both official and unofficial currency codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amount")]
    public AmountWithCurrency? TotalAmount { get; init; }

    /// <summary>
    /// Up to 3 top categories of expenses in this group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_categories")]
    public IReadOnlyList<CategoryExpenses>? TopCategories { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
