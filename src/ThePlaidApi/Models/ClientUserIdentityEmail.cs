using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// User email information.
/// </summary>
public record ClientUserIdentityEmail
{
    /// <summary>
    /// User's email.
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    /// <summary>
    /// Indicates whether this is the primary email for the User.
    /// </summary>
    [JsonPropertyName("primary")]
    public required bool Primary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
