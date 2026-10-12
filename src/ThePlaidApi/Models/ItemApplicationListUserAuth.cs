using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// User authentication parameters, for clients making a request without an <c>access_token</c>. This is only allowed for select clients and will not be supported in the future. Most clients should call <c>/item/import</c> to obtain an access token before making a request.
/// </summary>
public record ItemApplicationListUserAuth
{
    /// <summary>
    /// Account username.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// Account username hashed by FI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fi_username_hash")]
    public string? FiUsernameHash { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
