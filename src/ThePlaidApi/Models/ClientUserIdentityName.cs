using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// User name information.
/// </summary>
public record ClientUserIdentityName
{
    /// <summary>
    /// User's given name.
    /// </summary>
    [JsonPropertyName("given_name")]
    public required string GivenName { get; init; }

    /// <summary>
    /// User's family name.
    /// </summary>
    [JsonPropertyName("family_name")]
    public required string FamilyName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
