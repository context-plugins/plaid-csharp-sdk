using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing a credit card account.
/// </summary>
public record CreditCardLiability
{
    /// <summary>
    /// The ID of the account that this liability belongs to.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    /// <summary>
    /// The various interest rates that apply to the account. APR information is not provided by all card issuers; if APR data is not available, this array will be empty.
    /// </summary>
    [JsonPropertyName("aprs")]
    public required IReadOnlyList<Apr> Aprs { get; init; }

    /// <summary>
    /// true if a payment is currently overdue. Availability for this field is limited.
    /// </summary>
    [JsonPropertyName("is_overdue")]
    public required bool? IsOverdue { get; init; }

    /// <summary>
    /// The amount of the last payment.
    /// </summary>
    [JsonPropertyName("last_payment_amount")]
    public required double? LastPaymentAmount { get; init; }

    /// <summary>
    /// The date of the last payment. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD). Availability for this field is limited.
    /// </summary>
    [JsonPropertyName("last_payment_date")]
    public required DateTimeOffset? LastPaymentDate { get; init; }

    /// <summary>
    /// The date of the last statement. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("last_statement_issue_date")]
    public required DateTimeOffset? LastStatementIssueDate { get; init; }

    /// <summary>
    /// The total amount owed as of the last statement issued
    /// </summary>
    [JsonPropertyName("last_statement_balance")]
    public required double? LastStatementBalance { get; init; }

    /// <summary>
    /// The minimum payment due for the next billing cycle.
    /// </summary>
    [JsonPropertyName("minimum_payment_amount")]
    public required double? MinimumPaymentAmount { get; init; }

    /// <summary>
    /// The due date for the next payment. The due date is <c>null</c> if a payment is not expected. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("next_payment_due_date")]
    public required DateTimeOffset? NextPaymentDueDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
