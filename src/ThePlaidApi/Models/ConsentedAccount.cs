using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A financial institution account.
/// </summary>
public record ConsentedAccount
{
    /// <summary>
    /// Plaid's unique identifier for the account. Like all Plaid identifiers, the <c>account_id</c> is case sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mask")]
    public string? Mask { get; init; }

    /// <summary>
    /// The name of the account, either assigned by the user or by the financial institution itself
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The official name of the account as given by the financial institution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("official_name")]
    public string? OfficialName { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public AccountType? Type { get; init; }

    /// <summary>
    /// See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subtype")]
    public AccountSubtype? Subtype { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
