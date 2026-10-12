using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information associated with the entity watchlist hit
/// </summary>
public record EntityScreeningHitData
{
    /// <summary>
    /// Documents associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documents")]
    public IReadOnlyList<EntityScreeningHitDocumentsItems>? Documents { get; init; }

    /// <summary>
    /// Email addresses associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_addresses")]
    public IReadOnlyList<EntityScreeningHitEmailsItems>? EmailAddresses { get; init; }

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
    public IReadOnlyList<EntityScreeningHitNamesItems>? Names { get; init; }

    /// <summary>
    /// Phone numbers associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_numbers")]
    public IReadOnlyList<EntityScreeningHitsPhoneNumberItems>? PhoneNumbers { get; init; }

    /// <summary>
    /// URLs associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("urls")]
    public IReadOnlyList<EntityScreeningHitUrlsItems>? Urls { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
