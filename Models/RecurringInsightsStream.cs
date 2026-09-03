using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights object for recurring transactions streams.
/// </summary>
public record RecurringInsightsStream
{
    /// <summary>
    /// A unique id for the stream.
    /// </summary>
    [JsonPropertyName("stream_id")]
    public required string StreamId { get; init; }

    /// <summary>
    /// The client-provided raw description of the most recent transaction in the stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The merchant or primary counterparty associated with the transaction stream.
    /// </summary>
    [JsonPropertyName("merchant_name")]
    public required string MerchantName { get; init; }

    /// <summary>
    /// The posted date of the earliest transaction in the stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oldest_transaction_date")]
    public DateTimeOffset? OldestTransactionDate { get; init; }

    /// <summary>
    /// The posted date of the latest transaction in the stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newest_transaction_date")]
    public DateTimeOffset? NewestTransactionDate { get; init; }

    /// <summary>
    /// The average number of days between each of the recurring transactions.
    /// </summary>
    [JsonPropertyName("average_days_apart")]
    public required double AverageDaysApart { get; init; }

    /// <summary>
    /// Describes the frequency of the transaction stream.
    /// <para>
    /// <c>WEEKLY</c>: Assigned to a transaction stream that occurs approximately every week.
    /// </para>
    /// <para>
    /// <c>BIWEEKLY</c>: Assigned to a transaction stream that occurs approximately every 2 weeks.
    /// </para>
    /// <para>
    /// <c>SEMI_MONTHLY</c>: Assigned to a transaction stream that occurs approximately twice per month. This frequency is typically seen for inflow transaction streams.
    /// </para>
    /// <para>
    /// <c>MONTHLY</c>: Assigned to a transaction stream that occurs approximately every month.
    /// </para>
    /// <para>
    /// <c>ANNUALLY</c>: Assigned to a transaction stream that occurs approximately every year.
    /// </para>
    /// <para>
    /// <c>UNKNOWN</c>: Assigned to a transaction stream that does not fit any of the pre-defined frequencies.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    public RecurringTransactionFrequency? Frequency { get; init; }

    /// <summary>
    /// The number of transactions in this stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_count")]
    public int? TransactionCount { get; init; }

    /// <summary>
    /// An array of Plaid transaction IDs belonging to the stream, sorted by posted date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_ids")]
    public IReadOnlyList<string>? TransactionIds { get; init; }

    /// <summary>
    /// Object with data pertaining to an amount on the transaction stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("average_amount")]
    public TransactionStreamAmount? AverageAmount { get; init; }

    /// <summary>
    /// Object with data pertaining to an amount on the transaction stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newest_transaction_amount")]
    public TransactionStreamAmount? NewestTransactionAmount { get; init; }

    /// <summary>
    /// Indicates whether the transaction stream is still live.
    /// </summary>
    [JsonPropertyName("is_active")]
    public required bool IsActive { get; init; }

    /// <summary>
    /// The current status of the transaction stream.
    /// <para>
    /// <c>MATURE</c>: A <c>MATURE</c> recurring stream should have at least 3 transactions and happen on a regular cadence (For Annual recurring stream, we will mark it <c>MATURE</c> after 2 instances).
    /// </para>
    /// <para>
    /// <c>EARLY_DETECTION</c>: When a recurring transaction first appears in the transaction history and before it fulfills the requirement of a mature stream, the status will be <c>EARLY_DETECTION</c>.
    /// </para>
    /// <para>
    /// <c>TOMBSTONED</c>: A stream that was previously in the <c>EARLY_DETECTION</c> status will move to the <c>TOMBSTONED</c> status when no further transactions were found at the next expected date.
    /// </para>
    /// <para>
    /// <c>UNKNOWN</c>: A stream is assigned an <c>UNKNOWN</c> status when none of the other statuses are applicable.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TransactionStreamStatus? Status { get; init; }

    /// <summary>
    /// The primary category associated with the transaction stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category_primary")]
    public string? PersonalFinanceCategoryPrimary { get; init; }

    /// <summary>
    /// The detailed category associated with the transaction stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category_detailed")]
    public string? PersonalFinanceCategoryDetailed { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
