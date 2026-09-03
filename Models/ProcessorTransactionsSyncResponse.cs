using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorTransactionsSyncResponse defines the response schema for <c>/processor/transactions/sync</c>
/// </summary>
public record ProcessorTransactionsSyncResponse
{
    /// <summary>
    /// A description of the update status for transaction pulls of an Item. This field contains the same information provided by transactions webhooks, and may be helpful for webhook troubleshooting or when recovering from missed webhooks.
    /// <para>
    /// <c>TRANSACTIONS_UPDATE_STATUS_UNKNOWN</c>: Unable to fetch transactions update status for Item.
    /// <c>NOT_READY</c>: The Item is pending transaction pull.
    /// <c>INITIAL_UPDATE_COMPLETE</c>: Initial pull for the Item is complete, historical pull is pending.
    /// <c>HISTORICAL_UPDATE_COMPLETE</c>: Both initial and historical pull for Item are complete.
    /// </para>
    /// </summary>
    [JsonPropertyName("transactions_update_status")]
    public required TransactionsUpdateStatus TransactionsUpdateStatus { get; init; }

    /// <summary>
    /// A single account at a financial institution.
    /// </summary>
    [JsonPropertyName("account")]
    public required AccountNullable? Account { get; init; }

    /// <summary>
    /// Transactions that have been added to the Item since <c>cursor</c> ordered by ascending last modified time.
    /// </summary>
    [JsonPropertyName("added")]
    public required IReadOnlyList<Transaction> Added { get; init; }

    /// <summary>
    /// Transactions that have been modified on the Item since <c>cursor</c> ordered by ascending last modified time.
    /// </summary>
    [JsonPropertyName("modified")]
    public required IReadOnlyList<Transaction> Modified { get; init; }

    /// <summary>
    /// Transactions that have been removed from the Item since <c>cursor</c> ordered by ascending last modified time.
    /// </summary>
    [JsonPropertyName("removed")]
    public required IReadOnlyList<RemovedTransaction> Removed { get; init; }

    /// <summary>
    /// Cursor used for fetching any future updates after the latest update provided in this response. The cursor obtained after all pages have been pulled (indicated by <c>has_more</c> being <c>false</c>) will be valid for at least 1 year. This cursor should be persisted for later calls. If transactions are not yet available, this will be an empty string.
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public required string NextCursor { get; init; }

    /// <summary>
    /// Represents if more than requested count of transaction updates exist. If true, the additional updates can be fetched by making an additional request with <c>cursor</c> set to <c>next_cursor</c>. If <c>has_more</c> is true, it's important to pull all available pages, to make it less likely for underlying data changes to conflict with pagination.
    /// </summary>
    [JsonPropertyName("has_more")]
    public required bool HasMore { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
