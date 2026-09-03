using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// You can use this field to pre-populate the user's legal name; if it is provided here, they will not be prompted to enter their name in the identity verification attempt.
/// </summary>
public record IdentityVerificationRequestUserName
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
