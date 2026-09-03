using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data returned from the financial institution about the owner or owners of an account. Only the <c>names</c> array must be non-empty.
/// </summary>
public record Owner
{
    /// <summary>
    /// A list of names associated with the account by the financial institution. In the case of a joint account, Plaid will make a best effort to report the names of all account holders.
    /// <para>
    /// If an Item contains multiple accounts with different owner names, some institutions will report all names associated with the Item in each account's <c>names</c> array.
    /// </para>
    /// </summary>
    [JsonPropertyName("names")]
    public required IReadOnlyList<string> Names { get; init; }

    /// <summary>
    /// A list of phone numbers associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public required IReadOnlyList<PhoneNumber> PhoneNumbers { get; init; }

    /// <summary>
    /// A list of email addresses associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.
    /// </summary>
    [JsonPropertyName("emails")]
    public required IReadOnlyList<Email> Emails { get; init; }

    /// <summary>
    /// Data about the various addresses associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.
    /// </summary>
    [JsonPropertyName("addresses")]
    public required IReadOnlyList<Address> Addresses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
