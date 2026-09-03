using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data to populate as test transaction data. If not specified, random transactions will be generated instead.
/// </summary>
public record TransactionOverride
{
    /// <summary>
    /// The date of the transaction, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format. Transactions in Sandbox will move from pending to posted once their transaction date has been reached. If a <c>date_transacted</c> is not provided by the institution, a transaction date may be available in the <see href="https://plaid.com/docs/api/products/transactions/#transactions-get-response-transactions-authorized-date"><c>authorized_date</c></see> field.
    /// </summary>
    [JsonPropertyName("date_transacted")]
    public required DateTimeOffset DateTransacted { get; init; }

    /// <summary>
    /// The date the transaction posted, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format. Posted dates in the past or present will result in posted transactions; posted dates in the future will result in pending transactions.
    /// </summary>
    [JsonPropertyName("date_posted")]
    public required DateTimeOffset DatePosted { get; init; }

    /// <summary>
    /// The transaction amount. Can be negative.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The transaction description.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The ISO-4217 format currency code for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
