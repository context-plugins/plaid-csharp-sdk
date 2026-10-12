using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

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
public record IdentityVerificationCreateRequestUser
{
    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// A valid phone number in E.164 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// You can use this field to pre-populate the user's legal name; if it is provided here, they will not be prompted to enter their name in the identity verification attempt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public IdentityVerificationRequestUserName? Name { get; init; }

    /// <summary>
    /// Home address for the user. Supported values are: not provided, address with only country code or full address.
    /// <para>
    /// For more context on this field, see <see href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#input-validation-by-country">Input Validation by Country</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public UserAddress? Address { get; init; }

    /// <summary>
    /// ID number submitted by the user, currently used only for the Identity Verification product. If the user has not submitted this data yet, this field will be <c>null</c>. Otherwise, both fields are guaranteed to be filled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_number")]
    public UserIdNumber? IdNumber { get; init; }

    /// <summary>
    /// Specifying <c>user.client_user_id</c> is deprecated. Please provide <c>client_user_id</c> at the root level instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

    /// <summary>
    /// An IPv4 or IPv6 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
