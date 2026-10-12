using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Name information for the associated entity watchlist hit
/// </summary>
public record EntityScreeningHitNames
{
    /// <summary>
    /// The full name of the entity.
    /// </summary>
    [JsonPropertyName("full")]
    public required string Full { get; init; }

    /// <summary>
    /// Primary names are those most commonly used to refer to this entity. Only one name will ever be marked as primary.
    /// </summary>
    [JsonPropertyName("is_primary")]
    public required bool IsPrimary { get; init; }

    /// <summary>
    /// Names that are explicitly marked as low quality either by their <c>source</c> list, or by <c>plaid</c> by a series of additional checks done by Plaid. Plaid does not ever surface a hit as a result of a weak name alone. If a name has no quality issues, this value will be <c>none</c>.
    /// </summary>
    [JsonPropertyName("weak_alias_determination")]
    public required WeakAliasDetermination WeakAliasDetermination { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
