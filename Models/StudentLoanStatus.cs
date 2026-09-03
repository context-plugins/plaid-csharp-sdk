using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the status of the student loan
/// </summary>
public record StudentLoanStatus
{
    /// <summary>
    /// The date until which the loan will be in its current status. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The status type of the student loan
    /// </summary>
    [JsonPropertyName("type")]
    public required Type2? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
