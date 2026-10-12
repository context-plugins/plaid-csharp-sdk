using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights into negative balance occurrences, including frequency, duration, and minimum balance details.
/// </summary>
public record NegativeBalanceInsights
{
    /// <summary>
    /// The number of days since the last transaction that caused any account in the report to have a negative balance.
    /// <para>
    /// This value is inclusive of the date of the last negative balance, meaning that if the last negative balance occurred today, this value will be <c>0</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_last_occurrence")]
    public int? DaysSinceLastOccurrence { get; init; }

    /// <summary>
    /// The number of aggregated days that the accounts in the report has had a negative balance within the given time window.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_with_negative_balance")]
    public int? DaysWithNegativeBalance { get; init; }

    /// <summary>
    /// A monetary amount with its associated currency information, supporting both official and unofficial currency codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimum_balance")]
    public AmountWithCurrency? MinimumBalance { get; init; }

    /// <summary>
    /// The summary of the negative balance occurrences for this account.
    /// <para>
    /// If the user has not had a negative balance in the account in the given time window, this list will be empty.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occurrences")]
    public IReadOnlyList<NegativeBalanceOccurrence?>? Occurrences { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
