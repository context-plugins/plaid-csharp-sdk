using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Phone number associated with a business
/// </summary>
public record BusinessPhoneNumber
{
    /// <summary>
    /// Phone number in E.164 format
    /// </summary>
    [JsonPropertyName("number")]
    public required string? Number { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
