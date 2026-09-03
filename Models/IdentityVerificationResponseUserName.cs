using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The full name provided by the user. If the user has not submitted their name, this field will be null. Otherwise, both fields are guaranteed to be filled.
/// </summary>
public record IdentityVerificationResponseUserName
{
    /// <summary>
    /// A string with at least one non-whitespace character, with a max length of 100 characters.
    /// </summary>
    [JsonPropertyName("given_name")]
    public required string GivenName { get; init; }

    /// <summary>
    /// A string with at least one non-whitespace character, with a max length of 100 characters.
    /// </summary>
    [JsonPropertyName("family_name")]
    public required string FamilyName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
