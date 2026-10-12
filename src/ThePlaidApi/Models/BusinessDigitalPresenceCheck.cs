using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Results from the digital presence check.
/// </summary>
public record BusinessDigitalPresenceCheck
{
    /// <summary>
    /// Status of the digital presence check
    /// </summary>
    [JsonPropertyName("status")]
    public required BusinessVerificationStatusWebPresenceCheck Status { get; init; }

    /// <summary>
    /// A score from 0 to 100 indicating digital presence confidence.
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    /// <summary>
    /// Summary of how a specific business field matched against data provider results
    /// </summary>
    [JsonPropertyName("address")]
    public required BusinessFieldMatchSummary Address { get; init; }

    /// <summary>
    /// Summary of how a specific business field matched against data provider results
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required BusinessFieldMatchSummary PhoneNumber { get; init; }

    /// <summary>
    /// Summary of how a specific business field matched against data provider results
    /// </summary>
    [JsonPropertyName("email_address")]
    public required BusinessFieldMatchSummary EmailAddress { get; init; }

    /// <summary>
    /// Summary of how a specific business field matched against data provider results
    /// </summary>
    [JsonPropertyName("website")]
    public required BusinessFieldMatchSummary Website { get; init; }

    /// <summary>
    /// Website analysis details if a website is found for the provided website in the search terms.
    /// </summary>
    [JsonPropertyName("website_analysis")]
    public required BusinessWebsiteAnalysis? WebsiteAnalysis { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
