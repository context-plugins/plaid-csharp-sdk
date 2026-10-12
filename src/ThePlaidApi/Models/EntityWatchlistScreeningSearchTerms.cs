using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Search terms associated with an entity used for searching against watchlists
/// </summary>
public record EntityWatchlistScreeningSearchTerms
{
    /// <summary>
    /// ID of the associated entity program.
    /// </summary>
    [JsonPropertyName("entity_watchlist_program_id")]
    public required string EntityWatchlistProgramId { get; init; }

    /// <summary>
    /// The name of the organization being screened. Must have at least one alphabetical character, have a maximum length of 100 characters, and not include leading or trailing spaces.
    /// </summary>
    [JsonPropertyName("legal_name")]
    public required string LegalName { get; init; }

    /// <summary>
    /// The numeric or alphanumeric identifier associated with this document. Must be between 4 and 32 characters long, and cannot have leading or trailing spaces.
    /// </summary>
    [JsonPropertyName("document_number")]
    public required string? DocumentNumber { get; init; }

    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string? EmailAddress { get; init; }

    /// <summary>
    /// Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// A phone number in E.164 format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string? PhoneNumber { get; init; }

    /// <summary>
    /// An 'http' or 'https' URL (must begin with either of those).
    /// </summary>
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string? Url { get; init; }

    /// <summary>
    /// The current version of the search terms. Starts at <c>1</c> and increments with each edit to <c>search_terms</c>.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
