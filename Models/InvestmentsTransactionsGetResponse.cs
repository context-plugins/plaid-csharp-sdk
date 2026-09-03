using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// InvestmentsTransactionsGetResponse defines the response schema for <c>/investments/transactions/get</c>
/// </summary>
public record InvestmentsTransactionsGetResponse
{
    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// The accounts for which transaction history is being fetched.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<InvestmentAccount> Accounts { get; init; }

    /// <summary>
    /// All securities for which there is a corresponding transaction being fetched.
    /// </summary>
    [JsonPropertyName("securities")]
    public required IReadOnlyList<Security> Securities { get; init; }

    /// <summary>
    /// The transactions being fetched
    /// </summary>
    [JsonPropertyName("investment_transactions")]
    public required IReadOnlyList<InvestmentTransaction> InvestmentTransactions { get; init; }

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
