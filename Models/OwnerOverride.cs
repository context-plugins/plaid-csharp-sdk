using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data about the owner or owners of an account. Any fields not specified will be filled in with default Sandbox information.
/// </summary>
public record OwnerOverride
{
    /// <summary>
    /// A list of names associated with the account by the financial institution. These should always be the names of individuals, even for business accounts. Note that the same name data will be used for all accounts associated with an Item.
    /// </summary>
    [JsonPropertyName("names")]
    public required IReadOnlyList<string> Names { get; init; }

    /// <summary>
    /// A list of phone numbers associated with the account.
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public required IReadOnlyList<PhoneNumber> PhoneNumbers { get; init; }

    /// <summary>
    /// A list of email addresses associated with the account.
    /// </summary>
    [JsonPropertyName("emails")]
    public required IReadOnlyList<Email> Emails { get; init; }

    /// <summary>
    /// Data about the various addresses associated with the account.
    /// </summary>
    [JsonPropertyName("addresses")]
    public required IReadOnlyList<Address> Addresses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
