using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorInvestmentsTransactionsGetResponse defines the response schema for <c>/processor/investments/transactions/get</c>
/// </summary>
public record ProcessorInvestmentsTransactionsGetResponse
{
    /// <summary>
    /// A single account at a financial institution, with additional investment-specific balance information.
    /// </summary>
    [JsonPropertyName("account")]
    public required InvestmentAccount Account { get; init; }

    /// <summary>
    /// An array containing investment transactions from the account. Investments transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the <c>count</c> parameter.
    /// </summary>
    [JsonPropertyName("investment_transactions")]
    public required IReadOnlyList<InvestmentTransaction> InvestmentTransactions { get; init; }

    /// <summary>
    /// All securities for which there is a corresponding transaction being fetched.
    /// </summary>
    [JsonPropertyName("securities")]
    public required IReadOnlyList<Security> Securities { get; init; }

    /// <summary>
    /// The total number of transactions available within the date range specified. If <c>total_investment_transactions</c> is larger than the size of the <c>transactions</c> array, more transactions are available and can be fetched via manipulating the <c>offset</c> parameter.
    /// </summary>
    [JsonPropertyName("total_investment_transactions")]
    public required int TotalInvestmentTransactions { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// When true, this field indicates that the Item's portfolio was manually created with the Investments Fallback flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_investments_fallback_item")]
    public bool? IsInvestmentsFallbackItem { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
