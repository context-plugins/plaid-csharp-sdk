using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object of user ID and auth token pair, permitting Plaid to aggregate a user's accounts
/// </summary>
public record ItemImportRequestUserAuth
{
    /// <summary>
    /// Opaque user identifier
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// Authorization token Plaid will use to aggregate this user's accounts
    /// </summary>
    [JsonPropertyName("auth_token")]
    public required string AuthToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
