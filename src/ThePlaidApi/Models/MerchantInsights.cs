using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights into a user's top merchants.
/// </summary>
public record MerchantInsights
{
    /// <summary>
    /// The counterparty name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A unique, stable, Plaid-generated id that maps to the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }

    /// <summary>
    /// The website associated with the merchant.
    /// </summary>
    [JsonPropertyName("website")]
    public required string? Website { get; init; }

    /// <summary>
    /// The number of transactions associated with merchant of this type.
    /// </summary>
    [JsonPropertyName("transaction_count")]
    public required int TransactionCount { get; init; }

    /// <summary>
    /// The primary personal finance category associated with this merchant.
    /// </summary>
    [JsonPropertyName("personal_finance_category_primary")]
    public required string? PersonalFinanceCategoryPrimary { get; init; }

    /// <summary>
    /// The detailed personal finance category associated with this merchant.
    /// </summary>
    [JsonPropertyName("personal_finance_category_detailed")]
    public required string? PersonalFinanceCategoryDetailed { get; init; }

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
