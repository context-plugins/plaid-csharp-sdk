using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// The identity data that was either collected from the user or provided via API in order to perform an Identity Verification.
/// </summary>
public record IdentityVerificationUserData
{
    /// <summary>
    /// A valid phone number in E.164 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// An IPv4 or IPv6 address.
    /// </summary>
    [JsonPropertyName("ip_address")]
    public required string? IpAddress { get; init; }

    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string? EmailAddress { get; init; }

    /// <summary>
    /// The full name provided by the user. If the user has not submitted their name, this field will be null. Otherwise, both fields are guaranteed to be filled.
    /// </summary>
    [JsonPropertyName("name")]
    public required IdentityVerificationResponseUserName? Name { get; init; }

    /// <summary>
    /// Even if an address has been collected, some fields may be null depending on the region's addressing system. For example:
    /// <para>
    /// Addresses from the United Kingdom will not include a region
    /// </para>
    /// <para>
    /// Addresses from Hong Kong will not include postal code
    /// </para>
    /// </summary>
    [JsonPropertyName("address")]
    public required IdentityVerificationUserAddress? Address { get; init; }

    /// <summary>
    /// ID number submitted by the user, currently used only for the Identity Verification product. If the user has not submitted this data yet, this field will be <c>null</c>. Otherwise, both fields are guaranteed to be filled.
    /// </summary>
    [JsonPropertyName("id_number")]
    public required UserIdNumber? IdNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
