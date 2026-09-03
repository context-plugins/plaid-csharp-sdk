using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the fixed income security.
/// </summary>
public record FixedIncome
{
    /// <summary>
    /// Details about a fixed income security's expected rate of return.
    /// </summary>
    [JsonPropertyName("yield_rate")]
    public required YieldRate? YieldRate { get; init; }

    /// <summary>
    /// The maturity date for this fixed income security, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("maturity_date")]
    public required DateTimeOffset? MaturityDate { get; init; }

    /// <summary>
    /// The issue date for this fixed income security, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("issue_date")]
    public required DateTimeOffset? IssueDate { get; init; }

    /// <summary>
    /// The face value that is paid upon maturity of the fixed income security, per unit of security.
    /// </summary>
    [JsonPropertyName("face_value")]
    public required double? FaceValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
