using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Affordability insights focus on providing signal on the ability of a borrower to repay their loan without experiencing financial strain. It provides insights on factors such as a user's monthly income and expenses, disposable income, average expenditure, etc., helping lenders gauge the level of affordability of a borrower.
/// </summary>
public record AffordabilityInsights
{
    /// <summary>
    /// Comprehensive analysis of spending patterns, categorizing expenses into essential, non-essential, and other categories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expenditure")]
    public ExpenditureInsights? Expenditure { get; init; }

    /// <summary>
    /// Comprehensive income analysis including total income, income excluding transfers, and inbound transfer amounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income")]
    public IncomeInsights? Income { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
