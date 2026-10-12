using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains the payment information for a loan payment period.
/// </summary>
public record CraLoanPaymentHistory
{
    /// <summary>
    /// The index to identify the loan's payment period, starting from 1.
    /// For example:
    ///   1 means the period between the loan's opening date and the 1st payment due date.
    ///   2 means the period between the loan's 1st payment due date and 2nd payment due date.
    /// </summary>
    [JsonPropertyName("period")]
    public required int Period { get; init; }

    /// <summary>
    /// The payment due date or end date of the payment period. The date should be in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("due_date")]
    public required DateTimeOffset DueDate { get; init; }

    /// <summary>
    /// The number of days the loan was delinquent at the end of the pay period.
    /// If specified, should be greater than or equal to 0.
    /// </summary>
    [JsonPropertyName("days_past_due")]
    public required int DaysPastDue { get; init; }

    /// <summary>
    /// The amount past due or the charge-off amount of the loan at the end of the payment period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_past_due")]
    public double? AmountPastDue { get; init; }

    /// <summary>
    /// The balance remaining on the loan at the end of the payment period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance_remaining")]
    public double? BalanceRemaining { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
