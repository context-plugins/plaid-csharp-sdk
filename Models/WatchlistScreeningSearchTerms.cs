using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Search terms for creating an individual watchlist screening
/// </summary>
public record WatchlistScreeningSearchTerms
{
    /// <summary>
    /// ID of the associated program.
    /// </summary>
    [JsonPropertyName("watchlist_program_id")]
    public required string WatchlistProgramId { get; init; }

    /// <summary>
    /// The legal name of the individual being screened. Must have at least one alphabetical character, have a maximum length of 100 characters, and not include leading or trailing spaces.
    /// </summary>
    [JsonPropertyName("legal_name")]
    public required string LegalName { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The numeric or alphanumeric identifier associated with this document. Must be between 4 and 32 characters long, and cannot have leading or trailing spaces.
    /// </summary>
    [JsonPropertyName("document_number")]
    public required string? DocumentNumber { get; init; }

    /// <summary>
    /// Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// The current version of the search terms. Starts at <c>1</c> and increments with each edit to <c>search_terms</c>.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
