using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an Income Report within the Home Lending Report.
/// </summary>
public record CraVerificationIncomeReport
{
    /// <summary>
    /// The time when the Home Lending Income Report was generated.
    /// </summary>
    [JsonPropertyName("generated_time")]
    public required DateTimeOffset GeneratedTime { get; init; }

    /// <summary>
    /// The number of days requested by the customer for the Home Lending Income Report.
    /// </summary>
    [JsonPropertyName("days_requested")]
    public required int DaysRequested { get; init; }

    /// <summary>
    /// Aggregated summary of all income streams for this user.
    /// </summary>
    [JsonPropertyName("user_summary")]
    public required CraVerificationIncomeUserSummary? UserSummary { get; init; }

    /// <summary>
    /// The list of income streams for this user.
    /// </summary>
    [JsonPropertyName("income_streams")]
    public required IReadOnlyList<CraVerificationIncomeStream> IncomeStreams { get; init; }

    /// <summary>
    /// The list of Items in the report along with the associated metadata about the Item.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CraVerificationIncomeItem> Items { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
