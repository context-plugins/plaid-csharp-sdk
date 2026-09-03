using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The object containing data about the income provider.
/// </summary>
public record CraBankIncomeIncomeProvider
{
    /// <summary>
    /// The name of the income provider.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Indicates whether the income provider name is normalized by comparing it against a canonical set of known providers.
    /// </summary>
    [JsonPropertyName("is_normalized")]
    public required bool IsNormalized { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
