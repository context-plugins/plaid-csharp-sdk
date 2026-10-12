using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object for <c>/credit/bank_income/refresh</c> request options.
/// </summary>
public record CreditBankIncomeRefreshRequestOptions
{
    /// <summary>
    /// How many days of data to include in the refresh. If not specified, this will default to the days requested in the most recently generated bank income report for the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    public int? DaysRequested { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
