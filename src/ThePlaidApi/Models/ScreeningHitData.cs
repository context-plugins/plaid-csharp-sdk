using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information associated with the watchlist hit
/// </summary>
public record ScreeningHitData
{
    /// <summary>
    /// Dates of birth associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dates_of_birth")]
    public IReadOnlyList<ScreeningHitDateOfBirthItem>? DatesOfBirth { get; init; }

    /// <summary>
    /// Documents associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documents")]
    public IReadOnlyList<ScreeningHitDocumentsItems>? Documents { get; init; }

    /// <summary>
    /// Locations associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locations")]
    public IReadOnlyList<GenericScreeningHitLocationItems>? Locations { get; init; }

    /// <summary>
    /// Names associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("names")]
    public IReadOnlyList<ScreeningHitNamesItems>? Names { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
