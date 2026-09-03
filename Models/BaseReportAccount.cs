using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Base Report information about an account
/// </summary>
public record BaseReportAccount
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
    /// Information about an account's balances.
    /// </summary>
    [JsonPropertyName("balances")]
    public required BaseReportAccountBalances Balances { get; init; }

    /// <summary>
    /// The information about previously submitted valid dispute statements by the consumer
    /// </summary>
    [JsonPropertyName("consumer_disputes")]
    public required IReadOnlyList<ConsumerDispute> ConsumerDisputes { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.
    /// </summary>
    [JsonPropertyName("mask")]
    public required string? Mask { get; init; }

    /// <summary>
    /// Metadata about the extracted account.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required BaseReportAccountMetadata Metadata { get; init; }

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
    /// The duration of transaction history available within this report for this Item, typically defined as the time since the date of the earliest transaction in that account.
    /// </summary>
    [JsonPropertyName("days_available")]
    public required double DaysAvailable { get; init; }

    /// <summary>
    /// Transaction history associated with the account. Transaction history returned by endpoints such as <c>/transactions/get</c> or <c>/investments/transactions/get</c> will be returned in the top-level <c>transactions</c> field instead. Some transactions may have their details masked in accordance to the FCRA. These will appear with a <c>credit_category</c> of <c>MASKED_TRANSACTION_CATEGORY</c>.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<BaseReportTransaction> Transactions { get; init; }

    /// <summary>
    /// Data returned by the financial institution about the account owner or owners. For business accounts, the name reported may be either the name of the individual or the name of the business, depending on the institution. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array. This array can also be empty if no owners are found.
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
    [JsonPropertyName("ownership_type")]
    public required OwnershipType? OwnershipType { get; init; }

    /// <summary>
    /// Calculated data about the historical balances on the account. Currently not supported by <c>brokerage</c> or <c>investment</c> accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_balances")]
    public IReadOnlyList<BaseReportHistoricalBalance>? HistoricalBalances { get; init; }

    /// <summary>
    /// Calculated insights derived from transaction-level data. This field has been deprecated in favor of <see href="https://plaid.com/docs/api/products/check/#cra-check_report-base_report-get-response-report-attributes">Base Report attributes aggregated across accounts</see> and will be removed in a future release.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_insights")]
    public BaseReportAccountInsights? AccountInsights { get; init; }

    /// <summary>
    /// Calculated attributes derived from transaction-level data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public BaseReportAttributes? Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
