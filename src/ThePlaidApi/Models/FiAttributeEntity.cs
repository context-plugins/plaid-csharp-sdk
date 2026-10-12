using System.Text.Json.Serialization;

namespace ThePlaidApi.Models;

/// <summary>
/// Financial Institution provider-specific attribute
/// </summary>
public record FiAttributeEntity
{
    /// <summary>
    /// Name of attribute
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Value of attribute
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
