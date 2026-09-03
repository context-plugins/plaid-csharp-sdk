using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Request schema for <c>/identity_verification/create</c>
/// </summary>
public record IdentityVerificationCreateRequest
{
    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

    /// <summary>
    /// Unique user identifier, created by calling <c>/user/create</c>. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. The <c>user_id</c> may only be used instead of the <c>client_user_id</c> if you were not a pre-existing user of <c>/user/create</c> as of December 10, 2025, or if you have since <see href="https://plaid.com/docs/api/users/migrate-to-new-user-apis">migrated to the new User APIs</see>; for more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>. If both this field and a <c>client_user_id</c> are present in a request, the <c>user_id</c> must have been created from the provided <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// A flag specifying whether you would like Plaid to expose a shareable URL for the verification being created.
    /// </summary>
    [JsonPropertyName("is_shareable")]
    public required bool IsShareable { get; init; }

    /// <summary>
    /// ID of the associated Identity Verification template. Like all Plaid identifiers, this is case-sensitive.
    /// </summary>
    [JsonPropertyName("template_id")]
    public required string TemplateId { get; init; }

    /// <summary>
    /// A flag specifying whether the end user has already agreed to a privacy policy specifying that their data will be shared with Plaid for verification purposes.
    /// <para>
    /// If <c>gave_consent</c> is set to <c>true</c>, the <c>accept_tos</c> step will be marked as <c>skipped</c> and the end user's session will start at the next step requirement.
    /// </para>
    /// </summary>
    [JsonPropertyName("gave_consent")]
    public bool GaveConsent { get; init; } = false;

    /// <summary>
    /// User information collected outside of Link, most likely via your own onboarding process.
    /// <para>
    /// Each of the following identity fields are optional:
    /// </para>
    /// <para>
    /// <c>email_address</c>
    /// </para>
    /// <para>
    /// <c>phone_number</c>
    /// </para>
    /// <para>
    /// <c>date_of_birth</c>
    /// </para>
    /// <para>
    /// <c>name</c>
    /// </para>
    /// <para>
    /// <c>address</c>
    /// </para>
    /// <para>
    /// <c>id_number</c>
    /// </para>
    /// <para>
    /// Specifically, these fields are optional in that they can either be fully provided (satisfying every required field in their subschema) or omitted from the request entirely by not providing the key or value.
    /// Providing these fields via the API will result in Link skipping the data collection process for the associated user. All verification steps enabled in the associated Identity Verification Template will still be run. Verification steps will either be run immediately, or once the user completes the <c>accept_tos</c> step, depending on the value provided to the <c>gave_consent</c> field.
    /// If you are not using the shareable URL feature, you can optionally provide these fields via <c>/link/token/create</c> instead; both <c>/identity_verification/create</c> and <c>/link/token/create</c> are valid ways to provide this information. Note that if you provide a non-<c>null</c> user data object via <c>/identity_verification/create</c>, any user data fields entered via <c>/link/token/create</c> for the same <c>client_user_id</c> will be ignored when prefilling Link.
    /// </para>
    /// <para>
    /// The <c>ip_address</c> field is optional. Provide the end user's IP address to enable IP-based risk checks for backend-only integrations that do not use the Link SDK; when the Link SDK is used, the IP address is collected automatically. Unlike the identity fields above, <c>ip_address</c> cannot be provided via <c>/link/token/create</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public IdentityVerificationCreateRequestUser? User { get; init; }

    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// An optional flag specifying how you would like Plaid to handle attempts to create an Identity Verification when an Identity Verification already exists for the provided <c>client_user_id</c> and/or <c>user_id</c>, and <c>template_id</c>.
    /// If idempotency is enabled, Plaid will return the existing Identity Verification. If idempotency is disabled, Plaid will reject the request with a <c>400 Bad Request</c> status code if an Identity Verification already exists for the supplied <c>client_user_id</c> and/or <c>user_id</c>, and <c>template_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_idempotent")]
    public bool? IsIdempotent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
