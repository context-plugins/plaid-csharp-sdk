using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// This is a container object for all lending-related insights. This field will be returned only for European customers.
/// </summary>
public record AccountInsights
{
    /// <summary>
    /// Risk indicators focus on providing signal on the possibility of a borrower defaulting on their loan repayments by providing data points related to its payment behavior, debt, and other relevant financial information, helping lenders gauge the level of risk involved in a certain operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk")]
    public RiskIndicators? Risk { get; init; }

    /// <summary>
    /// Affordability insights focus on providing signal on the ability of a borrower to repay their loan without experiencing financial strain. It provides insights on factors such as a user's monthly income and expenses, disposable income, average expenditure, etc., helping lenders gauge the level of affordability of a borrower.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affordability")]
    public AffordabilityInsights? Affordability { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
