using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights around a user's counterparties
/// </summary>
public record CounterpartyInsights
{
    /// <summary>
    /// Insights related to a user's transactions with other financial institutions, including detected account types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("financial_institution_insights")]
    public IReadOnlyList<FinancialInstitutionInsights>? FinancialInstitutionInsights { get; init; }

    /// <summary>
    /// Insights about a user's top merchants, ranked by spend.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_insights")]
    public IReadOnlyList<MerchantInsights>? MerchantInsights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
