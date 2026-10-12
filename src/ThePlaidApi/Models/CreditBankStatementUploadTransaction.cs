using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing data about a transaction appearing on a user-uploaded bank statement.
/// </summary>
public record CreditBankStatementUploadTransaction
{
    /// <summary>
    /// The value of the transaction. A negative amount indicates that money moved into the account (such as a paycheck being deposited).
    /// </summary>
    [JsonPropertyName("amount")]
    public required double? Amount { get; init; }

    /// <summary>
    /// The date of when the transaction was made, in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset? Date { get; init; }

    /// <summary>
    /// The raw description of the transaction as it appears on the bank statement.
    /// </summary>
    [JsonPropertyName("original_description")]
    public required string? OriginalDescription { get; init; }

    /// <summary>
    /// The unique id of the bank account that this transaction occurs in
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
