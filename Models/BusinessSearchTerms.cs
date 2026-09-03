using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// The business information that was used to perform the verification search
/// </summary>
public record BusinessSearchTerms
{
    /// <summary>
    /// The name of the business. Must have at least one character and a maximum length of 500 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    /// <summary>
    /// Alternative business names that were submitted as search inputs.
    /// </summary>
    [JsonPropertyName("alternative_names")]
    public required IReadOnlyList<string> AlternativeNames { get; init; }

    /// <summary>
    /// Physical address of a business. Used for response schemas.
    /// </summary>
    [JsonPropertyName("address")]
    public required ResponseBusinessAddress Address { get; init; }

    /// <summary>
    /// An 'http' or 'https' URL (must begin with either of those).
    /// </summary>
    [JsonPropertyName("website")]
    [Format(FormatKind.Uri)]
    public required string? Website { get; init; }

    /// <summary>
    /// A phone number in E.164 format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string? PhoneNumber { get; init; }

    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string? EmailAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
