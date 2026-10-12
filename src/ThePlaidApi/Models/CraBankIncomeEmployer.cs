using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The object containing employer data.
/// </summary>
public record CraBankIncomeEmployer
{
    /// <summary>
    /// The name of the employer.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
