using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights on the account level. These are only returned for Credit and Depository type accounts.
/// </summary>
public record CashflowAccountInsights
{
    /// <summary>
    /// Calculated data about the historical balances on the account.
    /// <para>
    /// Available for <c>credit</c> and <c>depository</c> type accounts.
    /// </para>
    /// </summary>
    [JsonPropertyName("historical_balances")]
    public required IReadOnlyList<CashflowReportHistoricalBalance> HistoricalBalances { get; init; }

    /// <summary>
    /// Monthly summary statistics derived from transaction-level data.
    /// </summary>
    [JsonPropertyName("monthly_summaries")]
    public required IReadOnlyList<CashflowReportMonthlySummary> MonthlySummaries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
