using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The identity fields associated with a user. For a user to be eligible for a Plaid Check Consumer Report, all fields are required except <c>id_number</c>. Providing a partial SSN is strongly recommended, and improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests. If creating a report that will be shared with GSEs such as Fannie or Freddie, a full Social Security Number must be provided via the <c>id_number</c> field.
/// </summary>
public record ClientUserIdentity
{
    /// <summary>
    /// User name information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ClientUserIdentityName? Name { get; init; }

    /// <summary>
    /// The user's date of birth, to be provided in the format "yyyy-mm-dd".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The user's emails.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emails")]
    public IReadOnlyList<ClientUserIdentityEmail>? Emails { get; init; }

    /// <summary>
    /// The user's phone numbers, in E.164 format: +{countrycode}{number}. For example: "+14157452130". Phone numbers provided in other formats will be parsed on a best-effort basis. Phone number input is validated against valid number ranges; number strings that do not match a real-world phone numbering scheme may cause the request to fail, even in the Sandbox test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_numbers")]
    public IReadOnlyList<ClientUserIdentityPhoneNumber>? PhoneNumbers { get; init; }

    /// <summary>
    /// The user's addresses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addresses")]
    public IReadOnlyList<ClientUserIdentityAddress>? Addresses { get; init; }

    /// <summary>
    /// The user's ID numbers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_numbers")]
    public IReadOnlyList<UserIdNumber?>? IdNumbers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
