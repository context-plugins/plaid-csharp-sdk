using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Search inputs for creating an entity watchlist screening
/// </summary>
public record EntityWatchlistSearchTerms
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_number")]
    public string? DocumentNumber { get; init; }

    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// A phone number in E.164 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// An 'http' or 'https' URL (must begin with either of those).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public string? Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
