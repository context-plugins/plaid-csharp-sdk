using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional set of parameters corresponding to transactions options.
/// </summary>
public record SandboxPublicTokenCreateRequestOptionsTransactions
{
    /// <summary>
    /// The earliest date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The most recent date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The maximum number of days of transaction history to request for the Transactions product.
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(730)]
    public int? DaysRequested { get; init; } = 90;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
