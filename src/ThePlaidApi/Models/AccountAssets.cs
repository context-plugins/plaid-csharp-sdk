using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Asset information about an account
/// </summary>
public record AccountAssets
{
    /// <summary>
    /// Plaid's unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.
    /// <para>
    /// The <c>account_id</c> can also change if the <c>access_token</c> is deleted and the same credentials that were used to generate that <c>access_token</c> are used to generate a new <c>access_token</c> on a later date. In that case, the new <c>account_id</c> will be different from the old <c>account_id</c>.
    /// </para>
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
    /// A set of fields describing the balance for an account. Balance information may be cached unless the balance object was returned by <c>/accounts/balance/get</c>.
    /// </summary>
    [JsonPropertyName("balances")]
    public required AssetReportAccountBalance Balances { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.
    /// </summary>
    [JsonPropertyName("mask")]
    public required string? Mask { get; init; }

    /// <summary>
    /// The name of the account, either assigned by the user or by the financial institution itself
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The official name of the account as given by the financial institution
    /// </summary>
    [JsonPropertyName("official_name")]
    public required string? OfficialName { get; init; }

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

    /// <summary>
    /// See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
    /// </summary>
    [JsonPropertyName("subtype")]
    public required AccountSubtype? Subtype { get; init; }

    /// <summary>
    /// The current verification status of an Auth Item initiated through Automated or Manual micro-deposits.  Returned for Auth Items only.
    /// <para>
    /// <c>pending_automatic_verification</c>: The Item is pending automatic verification.
    /// </para>
    /// <para>
    /// <c>pending_manual_verification</c>: The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the micro-deposit.
    /// </para>
    /// <para>
    /// <c>automatically_verified</c>: The Item has successfully been automatically verified.
    /// </para>
    /// <para>
    /// <c>manually_verified</c>: The Item has successfully been manually verified.
    /// </para>
    /// <para>
    /// <c>verification_expired</c>: Plaid was unable to automatically verify the deposit within 7 calendar days and will no longer attempt to validate the Item. Users may retry by submitting their information again through Link.
    /// </para>
    /// <para>
    /// <c>verification_failed</c>: The Item failed manual micro-deposit verification because the user exhausted all 3 verification attempts. Users may retry by submitting their information again through Link.
    /// </para>
    /// <para>
    /// <c>database_matched</c>: (deprecated) The Item has successfully been verified using Plaid's data sources. Only returned for Auth Items created via Database Match.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_status")]
    public VerificationStatus4? VerificationStatus { get; init; }

    /// <summary>
    /// A unique and persistent identifier for accounts that can be used to trace multiple instances of the same account across different Items for depository accounts. This is currently an opt-in field and only supported for Chase Items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("persistent_account_id")]
    public string? PersistentAccountId { get; init; }

    /// <summary>
    /// The duration of transaction history available within this report for this Item, typically defined as the time since the date of the earliest transaction in that account.
    /// </summary>
    [JsonPropertyName("days_available")]
    public required double DaysAvailable { get; init; }

    /// <summary>
    /// Transaction history associated with the account.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<AssetReportTransaction> Transactions { get; init; }

    /// <summary>
    /// A set of fields describing the investments data on an account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investments")]
    public AssetReportInvestments? Investments { get; init; }

    /// <summary>
    /// Data returned by the financial institution about the account owner or owners. For business accounts, the name reported may be either the name of the individual or the name of the business, depending on the institution. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array. In API versions 2018-05-22 and earlier, the <c>owners</c> object is not returned, and instead identity information is returned in the top level <c>identity</c> object. For more details, see <see href="https://plaid.com/docs/api/versioning/#version-2019-05-29">Plaid API versioning</see>
    /// </summary>
    [JsonPropertyName("owners")]
    public required IReadOnlyList<Owner> Owners { get; init; }

    /// <summary>
    /// How an asset is owned.
    /// <para>
    /// <c>association</c>: Ownership by a corporation, partnership, or unincorporated association, including for-profit and not-for-profit organizations.
    /// <c>individual</c>: Ownership by an individual.
    /// <c>joint</c>: Joint ownership by multiple parties.
    /// <c>trust</c>: Ownership by a revocable or irrevocable trust.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownership_type")]
    public OwnershipType? OwnershipType { get; init; }

    /// <summary>
    /// Calculated data about the historical balances on the account.
    /// <para>
    /// Available for <c>credit</c> and <c>depository</c> type accounts.
    /// </para>
    /// </summary>
    [JsonPropertyName("historical_balances")]
    public required IReadOnlyList<HistoricalBalance> HistoricalBalances { get; init; }

    /// <summary>
    /// This is a container object for all lending-related insights. This field will be returned only for European customers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_insights")]
    public AccountInsights? AccountInsights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
