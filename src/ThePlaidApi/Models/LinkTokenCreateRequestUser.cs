using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object specifying information about the end user who will be linking their account. <b>Required</b> if <c>user_id</c> isn't included.
/// </summary>
public record LinkTokenCreateRequestUser
{
    /// <summary>
    /// A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    [MinLength(1)]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// The user's full legal name, used for <see href="https://plaid.com/docs/auth/coverage/">micro-deposit based verification flows</see>. For a small number of customers on legacy flows, providing this field is required to enable micro-deposit-based flows. For all other customers, this field is optional. Providing the user's name in this field when using micro-deposit-based verification will streamline the end user experience, as the user will not be prompted to enter their name during the Link flow; Plaid will use the provided legal name instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legal_name")]
    public string? LegalName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name2? Name { get; init; }

    /// <summary>
    /// The user's phone number in <see href="https://en.wikipedia.org/wiki/E.164">E.164</see> format. If supplied, will be used when applicable to prefill phone number fields in Link for the <see href="https://plaid.com/docs/link/returning-user">returning user flow</see> and the <see href="https://plaid.com/docs/identity-verification">Identity Verification flow</see>. Phone number input is validated against valid number ranges; number strings that do not match a real-world phone numbering scheme may cause the request to fail, even in the Sandbox test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The date and time the phone number was verified in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This was previously an optional field used in the <see href="https://plaid.com/docs/link/returning-user">returning user experience</see>. This field is no longer required to enable the returning user experience.
    /// <para>
    ///  Only pass a verification time for a phone number that you have verified. If you have performed verification but don't have the time, you may supply a signal value of the start of the UNIX epoch.
    /// </para>
    /// <para>
    ///  Example: <c>2020-01-01T00:00:00Z</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number_verified_time")]
    public DateTimeOffset? PhoneNumberVerifiedTime { get; init; }

    /// <summary>
    /// The user's email address. Can be used to prefill Link fields when used with <see href="https://plaid.com/docs/identity-verification">Identity Verification</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The date and time the email address was verified in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This was previously an optional field used in the <see href="https://plaid.com/docs/link/returning-user">returning user experience</see>. This field is no longer required to enable the returning user experience.
    /// <para>
    ///  Only pass a verification time for an email address that you have verified. If you have performed verification but don't have the time, you may supply a signal value of the start of the UNIX epoch.
    /// </para>
    /// <para>
    ///  Example: <c>2020-01-01T00:00:00Z</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address_verified_time")]
    public DateTimeOffset? EmailAddressVerifiedTime { get; init; }

    /// <summary>
    /// Deprecated and not currently used, use the <c>id_number</c> field instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn")]
    public string? Ssn { get; init; }

    /// <summary>
    /// To be provided in the format "yyyy-mm-dd". Can be used to prefill Link fields when used with Identity Verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address1? Address { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_number")]
    public IdNumber? IdNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
