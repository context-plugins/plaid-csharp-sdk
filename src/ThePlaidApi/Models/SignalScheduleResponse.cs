using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SignalScheduleResponse defines the response schema for <c>/signal/schedule</c>
/// </summary>
public record SignalScheduleResponse
{
    /// <summary>
    /// The recommended optimal date to submit the debit entry, formatted in ISO 8601 "YYYY-MM-DD" (e.g., "2024-03-30"). The <c>optimal_date</c> is derived from the date with rank = 1 in the following recommendations array.
    /// <para>
    /// NOTE: The <c>default_payment_method</c> field specified in the request will affect the recommendation, since we're accounting for debit settlement time.
    /// </para>
    /// <para>
    /// The debit scheduling evaluation starts from the day the /signal/schedule request is submitted (Day 0) or the next banking day if the submission day is not a banking day, and extends through the following five banking days (Day 1 to Day 5). If no date within this period is considered likely to result in a successful debit attempt, <c>null</c> will be returned for the <c>optimal_date</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("optimal_date")]
    public required DateTimeOffset? OptimalDate { get; init; }

    /// <summary>
    /// This array provides a date-by-date evaluation of debit submission recommendations within the five banking day evaluation period. Each object in the array represents a retry recommendation for a specific date.
    /// </summary>
    [JsonPropertyName("recommendations")]
    public required IReadOnlyList<SignalScheduleRecommendation> Recommendations { get; init; }

    /// <summary>
    /// If bank information was not available to be used in the Signal Transaction Scores model, this array contains warnings describing why bank data is missing. If you want to receive an API error instead of scores in the case of missing bank data, file a support ticket or contact your Plaid account manager.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<SignalWarning> Warnings { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
