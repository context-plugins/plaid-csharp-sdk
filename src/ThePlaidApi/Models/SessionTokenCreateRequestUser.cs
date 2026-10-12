using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the end user. Required if a root-level <c>user_id</c> is not provided.
/// </summary>
public record SessionTokenCreateRequestUser
{
    /// <summary>
    /// A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
