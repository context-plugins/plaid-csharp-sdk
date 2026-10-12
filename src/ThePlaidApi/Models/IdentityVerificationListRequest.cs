using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Request input for listing Identity Verifications
/// </summary>
public record IdentityVerificationListRequest
{
    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// ID of the associated Identity Verification template. Like all Plaid identifiers, this is case-sensitive.
    /// </summary>
    [JsonPropertyName("template_id")]
    public required string TemplateId { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

    /// <summary>
    /// A unique user identifier, created by calling <c>/user/create</c>. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. The <c>user_id</c> may only be used instead of the <c>client_user_id</c> if you were not a pre-existing user of <c>/user/create</c> as of December 10, 2025, or if you have since <see href="https://plaid.com/docs/api/users/migrate-to-new-user-apis">migrated to the new User APIs</see>; for more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>. If both this field and the <c>client_user_id</c> are present in the request, the <c>user_id</c> must have been created from the provided <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// An identifier that determines which page of results you receive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
