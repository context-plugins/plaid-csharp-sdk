using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing information on contribution transactions for the 401k account. Note that the sum fields in this object represent the total of absolute contribution values.
/// </summary>
public record InvestmentsAuth401KContributionDetails
{
    /// <summary>
    /// A list of the most recent contribution transactions for the 401k account. Includes all contributions made on the same day.
    /// </summary>
    [JsonPropertyName("last_contribution_transactions")]
    public required IReadOnlyList<InvestmentTransaction> LastContributionTransactions { get; init; }

    /// <summary>
    /// Number of contribution transactions on this account, for the past month.
    /// </summary>
    [JsonPropertyName("contribution_count_1m")]
    public required int ContributionCount1M { get; init; }

    /// <summary>
    /// Sum of the contribution transactions on this account, for the past month.
    /// </summary>
    [JsonPropertyName("contribution_amount_1m")]
    public required double ContributionAmount1M { get; init; }

    /// <summary>
    /// Number of contribution transactions on this account, for the past 6 months.
    /// </summary>
    [JsonPropertyName("contribution_count_6m")]
    public required int ContributionCount6M { get; init; }

    /// <summary>
    /// Sum of the contribution transactions on this account, for the past 6 months.
    /// </summary>
    [JsonPropertyName("contribution_amount_6m")]
    public required double ContributionAmount6M { get; init; }

    /// <summary>
    /// Number of contribution transactions on this account, for the past 12 months.
    /// </summary>
    [JsonPropertyName("contribution_count_12m")]
    public required int ContributionCount12M { get; init; }

    /// <summary>
    /// Sum of the contribution transactions on this account, for the past 12 months.
    /// </summary>
    [JsonPropertyName("contribution_amount_12m")]
    public required double ContributionAmount12M { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
