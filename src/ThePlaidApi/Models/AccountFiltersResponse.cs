using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The <c>account_filters</c> specified in the original call to <c>/link/token/create</c>.
/// </summary>
public record AccountFiltersResponse
{
    /// <summary>
    /// A filter to apply to <c>depository</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("depository")]
    public DepositoryFilter? Depository { get; init; }

    /// <summary>
    /// A filter to apply to <c>credit</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit")]
    public CreditFilter? Credit { get; init; }

    /// <summary>
    /// A filter to apply to <c>loan</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan")]
    public LoanFilter? Loan { get; init; }

    /// <summary>
    /// A filter to apply to <c>investment</c>-type accounts (or <c>brokerage</c>-type accounts for API versions 2018-05-22 and earlier).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investment")]
    public InvestmentFilter? Investment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
