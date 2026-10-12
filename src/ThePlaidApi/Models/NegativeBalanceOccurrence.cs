using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about a specific occurrence of a negative balance period, including start and end dates.
/// </summary>
public record NegativeBalanceOccurrence
{
    /// <summary>
    /// The date of the first transaction that caused the account to have a negative balance.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The date of the last transaction that caused the account to have a negative balance.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// This date is inclusive, meaning that this was the last date that the account had a negative balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// A monetary amount with its associated currency information, supporting both official and unofficial currency codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimum_balance")]
    public AmountWithCurrency? MinimumBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
