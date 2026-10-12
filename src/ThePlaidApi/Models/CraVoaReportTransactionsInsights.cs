using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Transaction data associated with the account.
/// </summary>
public record CraVoaReportTransactionsInsights
{
    /// <summary>
    /// Transaction history associated with the account.
    /// </summary>
    [JsonPropertyName("all_transactions")]
    public required IReadOnlyList<BaseReportTransaction> AllTransactions { get; init; }

    /// <summary>
    /// The latest timeframe provided by the FI, in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The earliest timeframe provided by the FI, in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset? StartDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
