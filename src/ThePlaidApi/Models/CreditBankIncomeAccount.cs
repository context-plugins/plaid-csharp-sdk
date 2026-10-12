using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The Item's bank accounts that have the selected data.
/// </summary>
public record CreditBankIncomeAccount
{
    /// <summary>
    /// Plaid's unique identifier for the account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number.
    /// Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.
    /// </summary>
    [JsonPropertyName("mask")]
    public required string? Mask { get; init; }

    /// <summary>
    /// The name of the bank account.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The official name of the bank account.
    /// </summary>
    [JsonPropertyName("official_name")]
    public required string? OfficialName { get; init; }

    /// <summary>
    /// Valid account subtypes for depository accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-depository">Account schemas</see>.
    /// </summary>
    [JsonPropertyName("subtype")]
    public required DepositoryAccountSubtype Subtype { get; init; }

    /// <summary>
    /// The account type. This will always be <c>depository</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public required CreditBankIncomeAccountType Type { get; init; }

    /// <summary>
    /// Data returned by the financial institution about the account owner or owners. Identity information is optional, so field may return an empty array.
    /// </summary>
    [JsonPropertyName("owners")]
    public required IReadOnlyList<Owner> Owners { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
