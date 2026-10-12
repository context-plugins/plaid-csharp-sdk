using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Results from the KYB (Know Your Business) identity verification check
/// </summary>
public record BusinessKybCheck
{
    /// <summary>
    /// Status of the KYB (Know Your Business) identity assessment check
    /// </summary>
    [JsonPropertyName("status")]
    public required BusinessVerificationStatus Status { get; init; }

    /// <summary>
    /// A score from 0 to 100 indicating the confidence in KYB (Know Your Business) identity assessment for the business
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    /// <summary>
    /// Summary of how a specific business field matched against data provider results
    /// </summary>
    [JsonPropertyName("name")]
    public required BusinessFieldMatchSummary Name { get; init; }

    /// <summary>
    /// Summary of how a specific business field matched against data provider results
    /// </summary>
    [JsonPropertyName("address")]
    public required BusinessFieldMatchSummary Address { get; init; }

    /// <summary>
    /// Summary of how a specific business field matched against data provider results
    /// </summary>
    [JsonPropertyName("website")]
    public required BusinessFieldMatchSummary Website { get; init; }

    /// <summary>
    /// Detailed information about the business from data provider results
    /// </summary>
    [JsonPropertyName("match_details")]
    public required BusinessKybMatchDetails? MatchDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
