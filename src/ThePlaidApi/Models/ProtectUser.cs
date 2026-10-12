using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents an end user for <c>/protect/compute</c> requests.
/// </summary>
public record ProtectUser
{
    /// <summary>
    /// The Plaid User ID returned from a previous call to <c>/user/create</c>. This or <c>client_user_id</c> can be provided, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// A unique ID representing the end user, previously passed to <c>/user/create</c>. Maximum of 128 characters. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
