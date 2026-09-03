using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// A Beacon User's data which is used to check against duplicate records and the Beacon Fraud Network.
/// <para>
/// In order to create a Beacon User, in addition to the <c>name</c>, _either_ the <c>date_of_birth</c> _or_ the <c>depository_accounts</c> field must be provided.
/// </para>
/// </summary>
public record BeaconUserRequestData
{
    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The full name for a given Beacon User.
    /// </summary>
    [JsonPropertyName("name")]
    public required BeaconUserName Name { get; init; }

    /// <summary>
    /// Home address for the associated user. For more context on this field, see <see href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#input-validation-by-country">Input Validation by Country</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public BeaconUserRequestAddress? Address { get; init; }

    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// A phone number in E.164 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The ID number associated with a Beacon User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_number")]
    public BeaconUserIdNumber? IdNumber { get; init; }

    /// <summary>
    /// An IPv4 or IPv6 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// Provide a list of bank accounts that are associated with this Beacon User. These accounts will be scanned across the Beacon Network and used to find duplicate records.
    /// <para>
    /// Note: These accounts will not have Bank Account Insights. To receive Bank Account Insights please supply <c>access_tokens</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("depository_accounts")]
    public IReadOnlyList<BeaconUserRequestDepositoryAccount>? DepositoryAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
