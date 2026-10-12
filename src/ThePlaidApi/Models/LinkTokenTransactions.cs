using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Configuration parameters for the Transactions product
/// </summary>
public record LinkTokenTransactions
{
    /// <summary>
    /// The maximum number of days of transaction history to request for the Transactions product. The more transaction history is requested, the longer the historical update poll will take. The default value is 90 days. In Production, if a value under 30 is provided, a minimum of 30 days of history will be requested. Once Transactions has been added to an Item, this value cannot be updated.
    /// <para>
    /// Customers using <see href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</see> should request at least 180 days of history for optimal results.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(730)]
    public int? DaysRequested { get; init; } = 90;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
