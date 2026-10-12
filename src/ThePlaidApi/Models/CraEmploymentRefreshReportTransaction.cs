using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A transaction on the Employment Refresh Report. Note that this transaction differs from a Base Report transaction in that it will only be deposits, and the amounts will be omitted.
/// </summary>
public record CraEmploymentRefreshReportTransaction
{
    /// <summary>
    /// The ID of the account in which this transaction occurred.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The string returned by the financial institution to describe the transaction.
    /// </summary>
    [JsonPropertyName("original_description")]
    public required string OriginalDescription { get; init; }

    /// <summary>
    /// For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an ISO 8601 format ( <c>YYYY-MM-DD</c> ).
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// When <c>true</c>, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled.
    /// </summary>
    [JsonPropertyName("pending")]
    public required bool Pending { get; init; }

    /// <summary>
    /// The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
