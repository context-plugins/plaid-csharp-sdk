using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// User phone number information.
/// </summary>
public record ClientUserIdentityPhoneNumber
{
    /// <summary>
    /// User's phone number.
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    /// <summary>
    /// Indicates whether this is the primary phone number for the User.
    /// </summary>
    [JsonPropertyName("primary")]
    public required bool Primary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
