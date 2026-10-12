using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Website analysis details if a website is found for the provided website in the search terms.
/// </summary>
public record BusinessWebsiteAnalysis
{
    /// <summary>
    /// Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.
    /// </summary>
    [JsonPropertyName("is_parked")]
    public required BusinessCheckBooleanStatus IsParked { get; init; }

    /// <summary>
    /// Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.
    /// </summary>
    [JsonPropertyName("email_is_deliverable")]
    public required BusinessCheckBooleanStatus EmailIsDeliverable { get; init; }

    /// <summary>
    /// Build status of the business website.
    /// </summary>
    [JsonPropertyName("website_build_status")]
    public required BusinessWebsiteBuildStatus WebsiteBuildStatus { get; init; }

    /// <summary>
    /// WHOIS metadata for the business website domain.
    /// </summary>
    [JsonPropertyName("whois_record")]
    public required BusinessWhoisRecord WhoisRecord { get; init; }

    /// <summary>
    /// SSL status for the business website.
    /// </summary>
    [JsonPropertyName("ssl")]
    public required BusinessWebsiteSsl Ssl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
