using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Request input for retrying an identity verification attempt
/// </summary>
public record IdentityVerificationRetryRequest
{
    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// ID of the associated Identity Verification template. Like all Plaid identifiers, this is case-sensitive.
    /// </summary>
    [JsonPropertyName("template_id")]
    public required string TemplateId { get; init; }

    /// <summary>
    /// An instruction specifying what steps the new Identity Verification attempt should require the user to complete:
    /// <para>
    ///
    /// <c>reset</c> - Restart the user at the beginning of the session, regardless of whether they successfully completed part of their previous session.
    /// </para>
    /// <para>
    /// <c>incomplete</c> - Start the new session at the step that the user failed in the previous session, skipping steps that have already been successfully completed.
    /// </para>
    /// <para>
    /// <c>infer</c> - If the most recent Identity Verification attempt associated with the given <c>client_user_id</c> has a status of <c>failed</c> or <c>expired</c>, retry using the <c>incomplete</c> strategy. Otherwise, use the <c>reset</c> strategy.
    /// </para>
    /// <para>
    /// <c>custom</c> - Start the new session with a custom configuration, specified by the value of the <c>steps</c> field
    /// </para>
    /// <para>
    /// Note:
    /// </para>
    /// <para>
    /// The <c>incomplete</c> strategy cannot be applied if the session's failing step is <c>watchlist_screening</c> or <c>risk_check</c>.
    /// </para>
    /// <para>
    /// The <c>infer</c> strategy cannot be applied if the session's status is still <c>active</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("strategy")]
    public required Strategy Strategy { get; init; }

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
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public IdentityVerificationRequestUser? User { get; init; }

    /// <summary>
    /// Instructions for the <c>custom</c> retry strategy specifying which steps should be required or skipped.
    /// <para>
    ///
    /// Note:
    /// </para>
    /// <para>
    ///
    /// This field must be provided when the retry strategy is <c>custom</c> and must be omitted otherwise.
    /// </para>
    /// <para>
    /// Custom retries override settings in your Plaid Template. For example, if your Plaid Template has <c>verify_sms</c> disabled, a custom retry with <c>verify_sms</c> enabled will still require the step.
    /// </para>
    /// <para>
    /// The <c>selfie_check</c> step is currently not supported on the sandbox server. Sandbox requests will silently disable the <c>selfie_check</c> step when provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("steps")]
    public IdentityVerificationRetryRequestStepsObject? Steps { get; init; }

    /// <summary>
    /// A flag specifying whether you would like Plaid to expose a shareable URL for the verification being retried. If a value for this flag is not specified, the <c>is_shareable</c> setting from the original verification attempt will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_shareable")]
    public bool? IsShareable { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
