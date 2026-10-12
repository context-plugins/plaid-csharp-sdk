using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A grouping of related transactions
/// </summary>
public record TransactionStream
{
    /// <summary>
    /// The ID of the account to which the stream belongs
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// A unique id for the stream
    /// </summary>
    [JsonPropertyName("stream_id")]
    public required string StreamId { get; init; }

    /// <summary>
    /// A hierarchical array of the categories to which this transaction belongs. See <see href="https://plaid.com/docs/api/products/transactions/#categoriesget">Categories</see>.
    /// <para>
    /// All implementations are encouraged to use the new <c>personal_finance_category</c> instead of <c>category</c>. <c>personal_finance_category</c> provides more meaningful categorization and greater accuracy.
    /// </para>
    /// </summary>
    [JsonPropertyName("category")]
    public required IReadOnlyList<string>? Category { get; init; }

    /// <summary>
    /// The ID of the category to which this transaction belongs. See <see href="https://plaid.com/docs/api/products/transactions/#categoriesget">Categories</see>.
    /// <para>
    /// All implementations are encouraged to use the new <c>personal_finance_category</c> instead of <c>category</c>. <c>personal_finance_category</c> provides more meaningful categorization and greater accuracy.
    /// </para>
    /// </summary>
    [JsonPropertyName("category_id")]
    public required string? CategoryId { get; init; }

    /// <summary>
    /// A description of the transaction stream.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The merchant associated with the transaction stream.
    /// </summary>
    [JsonPropertyName("merchant_name")]
    public required string? MerchantName { get; init; }

    /// <summary>
    /// The posted date of the earliest transaction in the stream.
    /// </summary>
    [JsonPropertyName("first_date")]
    public required DateTimeOffset FirstDate { get; init; }

    /// <summary>
    /// The posted date of the latest transaction in the stream.
    /// </summary>
    [JsonPropertyName("last_date")]
    public required DateTimeOffset LastDate { get; init; }

    /// <summary>
    /// The predicted date of the next payment. This will only be set if the next payment date can be predicted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("predicted_next_date")]
    public DateTimeOffset? PredictedNextDate { get; init; }

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
    [JsonPropertyName("frequency")]
    public required RecurringTransactionFrequency Frequency { get; init; }

    /// <summary>
    /// An array of Plaid transaction IDs belonging to the stream, sorted by posted date.
    /// </summary>
    [JsonPropertyName("transaction_ids")]
    public required IReadOnlyList<string> TransactionIds { get; init; }

    /// <summary>
    /// Object with data pertaining to an amount on the transaction stream.
    /// </summary>
    [JsonPropertyName("average_amount")]
    public required TransactionStreamAmount AverageAmount { get; init; }

    /// <summary>
    /// Object with data pertaining to an amount on the transaction stream.
    /// </summary>
    [JsonPropertyName("last_amount")]
    public required TransactionStreamAmount LastAmount { get; init; }

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
    [JsonPropertyName("status")]
    public required TransactionStreamStatus Status { get; init; }

    /// <summary>
    /// Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.
    /// <para>
    /// See the <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy CSV file</see> for a full list of personal finance categories. If you are migrating to personal finance categories from the legacy categories, also refer to the <see href="https://plaid.com/docs/transactions/pfc-migration/">migration guide</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category")]
    public PersonalFinanceCategory? PersonalFinanceCategory { get; init; }

    /// <summary>
    /// As the ability to modify transactions streams has been discontinued, this field will always be <c>false</c>.
    /// </summary>
    [JsonPropertyName("is_user_modified")]
    public required bool IsUserModified { get; init; }

    /// <summary>
    /// The date and time of the most recent user modification. This will only be set if <c>is_user_modified</c> is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_user_modified_datetime")]
    public DateTimeOffset? LastUserModifiedDatetime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
