using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// SSL status for the business website.
/// </summary>
public record BusinessWebsiteSsl
{
    /// <summary>
    /// Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.
    /// </summary>
    [JsonPropertyName("is_valid")]
    public required BusinessCheckBooleanStatus IsValid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
