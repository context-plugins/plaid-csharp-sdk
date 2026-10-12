using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing data on the overall period of the statement.
/// </summary>
public record CreditBankStatementUploadBankAccountPeriod
{
    /// <summary>
    /// The start date of the statement period in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The end date of the statement period in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The starting balance of the bank account for the period.
    /// </summary>
    [JsonPropertyName("starting_balance")]
    public required double? StartingBalance { get; init; }

    /// <summary>
    /// The ending balance of the bank account for the period.
    /// </summary>
    [JsonPropertyName("ending_balance")]
    public required double? EndingBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
