using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Account information within the Home Lending Income Report.
/// </summary>
public record CraVerificationIncomeAccount
{
    /// <summary>
    /// Plaid's unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.
    /// <para>
    /// If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.
    /// </para>
    /// <para>
    /// Like all Plaid identifiers, the <c>account_id</c> is case sensitive.
    /// </para>
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
    /// An object containing metadata about the extracted account.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required CraBankIncomeAccountMetadata Metadata { get; init; }

    /// <summary>
    /// The name of the account, either assigned by the user or by the financial institution itself.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The official name of the account as given by the financial institution.
    /// </summary>
    [JsonPropertyName("official_name")]
    public required string? OfficialName { get; init; }

    /// <summary>
    /// See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
    /// </summary>
    [JsonPropertyName("subtype")]
    public required AccountSubtype? Subtype { get; init; }

    /// <summary>
    /// <c>investment:</c> Investment account. In API versions 2018-05-22 and earlier, this type is called <c>brokerage</c> instead.
    /// <para>
    /// <c>credit:</c> Credit card
    /// </para>
    /// <para>
    /// <c>depository:</c> Depository account
    /// </para>
    /// <para>
    /// <c>loan:</c> Loan account
    /// </para>
    /// <para>
    /// <c>other:</c> Non-specified account type
    /// </para>
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required AccountType Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
