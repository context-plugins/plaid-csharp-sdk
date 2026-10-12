using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.
/// </summary>
public record ExternalPaymentScheduleRequest
{
    /// <summary>
    /// The frequency interval of the payment.
    /// </summary>
    [JsonPropertyName("interval")]
    public required PaymentScheduleInterval Interval { get; init; }

    /// <summary>
    /// The day of the interval on which to schedule the payment.
    /// <para>
    /// If the payment interval is weekly, <c>interval_execution_day</c> should be an integer from 1 (Monday) to 7 (Sunday).
    /// </para>
    /// <para>
    /// If the payment interval is monthly, <c>interval_execution_day</c> should be an integer indicating which day of the month to make the payment on. Integers from 1 to 28 can be used to make a payment on that day of the month. Negative integers from -1 to -5 can be used to make a payment relative to the end of the month. To make a payment on the last day of the month, use -1; to make the payment on the second-to-last day, use -2, and so on.
    /// </para>
    /// </summary>
    [JsonPropertyName("interval_execution_day")]
    public required int IntervalExecutionDay { get; init; }

    /// <summary>
    /// A date in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD). Standing order payments will begin on the first <c>interval_execution_day</c> on or after the <c>start_date</c>.
    /// <para>
    /// If the first <c>interval_execution_day</c> on or after the start date is also the same day that <c>/payment_initiation/payment/create</c> was called, the bank *may* make the first payment on that day, but it is not guaranteed to do so.
    /// </para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// A date in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD). Standing order payments will end on the last <c>interval_execution_day</c> on or before the <c>end_date</c>.
    /// If the only <c>interval_execution_day</c> between the start date and the end date (inclusive) is also the same day that <c>/payment_initiation/payment/create</c> was called, the bank *may* make a payment on that day, but it is not guaranteed to do so.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The start date sent to the bank after adjusting for holidays or weekends.  Will be provided in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD). If the start date did not require adjustment, this field will be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjusted_start_date")]
    public DateTimeOffset? AdjustedStartDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
