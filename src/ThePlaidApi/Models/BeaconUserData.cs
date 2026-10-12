using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// A Beacon User's data and resulting analysis when checked against duplicate records and the Beacon Fraud Network.
/// </summary>
public record BeaconUserData
{
    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateTimeOffset DateOfBirth { get; init; }

    /// <summary>
    /// The full name for a given Beacon User.
    /// </summary>
    [JsonPropertyName("name")]
    public required BeaconUserName Name { get; init; }

    /// <summary>
    /// Even if an address has been collected, some fields may be null depending on the region's addressing system. For example:
    /// <para>
    ///
    /// Addresses from the United Kingdom will not include a region
    /// </para>
    /// <para>
    ///
    /// Addresses from Hong Kong will not include a postal code
    /// </para>
    /// </summary>
    [JsonPropertyName("address")]
    public required BeaconUserAddress Address { get; init; }

    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string? EmailAddress { get; init; }

    /// <summary>
    /// A phone number in E.164 format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string? PhoneNumber { get; init; }

    /// <summary>
    /// The ID number associated with a Beacon User.
    /// </summary>
    [JsonPropertyName("id_number")]
    public required BeaconUserIdNumber? IdNumber { get; init; }

    /// <summary>
    /// An IPv4 or IPv6 address.
    /// </summary>
    [JsonPropertyName("ip_address")]
    public required string? IpAddress { get; init; }

    [JsonPropertyName("depository_accounts")]
    public required IReadOnlyList<BeaconUserDepositoryAccount> DepositoryAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
