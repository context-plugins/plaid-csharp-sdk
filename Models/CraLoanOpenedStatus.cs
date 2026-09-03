using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains the status and date information of the loan when registering.
/// </summary>
public record CraLoanOpenedStatus
{
    /// <summary>
    /// The status of the loan.
    /// </summary>
    [JsonPropertyName("status")]
    public required CraLoanStatus Status { get; init; }

    /// <summary>
    /// The effective date for the status of the loan. The date should be in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
