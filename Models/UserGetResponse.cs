using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// UserGetResponse defines the response schema for <c>/user/get</c>.
/// </summary>
public record UserGetResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// Client provided user ID.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string? ClientUserId { get; init; }

    /// <summary>
    /// Timestamp of user creation.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp of last user update.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>
    /// The identity fields associated with a user. For a user to be eligible for a Plaid Check Consumer Report, all fields are required except <c>id_number</c>. Providing a partial SSN is strongly recommended, and improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests. If creating a report that will be shared with GSEs such as Fannie or Freddie, a full Social Security Number must be provided via the <c>id_number</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identity")]
    public ClientUserIdentity? Identity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
