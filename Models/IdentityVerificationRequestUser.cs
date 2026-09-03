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
/// </para>
/// </summary>
public record IdentityVerificationRequestUser
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
