using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Account associated with the Item.
/// </summary>
public record StatementsAccount
{
    /// <summary>
    /// Plaid's unique identifier for the account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.
    /// </summary>
    [JsonPropertyName("account_mask")]
    public required string AccountMask { get; init; }

    /// <summary>
    /// The name of the account, either assigned by the user or by the financial institution itself.
    /// </summary>
    [JsonPropertyName("account_name")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The official name of the account as given by the financial institution.
    /// </summary>
    [JsonPropertyName("account_official_name")]
    public required string AccountOfficialName { get; init; }

    /// <summary>
    /// The subtype of the account. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
    /// </summary>
    [JsonPropertyName("account_subtype")]
    public required string AccountSubtype { get; init; }

    /// <summary>
    /// The type of account. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
    /// </summary>
    [JsonPropertyName("account_type")]
    public required string AccountType { get; init; }

    /// <summary>
    /// The list of statements' metadata associated with this account.
    /// </summary>
    [JsonPropertyName("statements")]
    public required IReadOnlyList<StatementsStatement> Statements { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
