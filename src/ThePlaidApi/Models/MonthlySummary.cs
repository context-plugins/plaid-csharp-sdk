using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Monthly summary of transactions within a specific time period, showing aggregated amounts.
/// </summary>
public record MonthlySummary
{
    /// <summary>
    /// The start date of the month for the given report time window. Will be provided in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The end date of the month for the given report time window. Will be provided in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// A monetary amount with its associated currency information, supporting both official and unofficial currency codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amount")]
    public AmountWithCurrency? TotalAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
