using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Business identity information about an account
/// </summary>
public record BusinessAccount
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
    /// When using a CRA endpoint (an endpoint associated with Plaid Check Consumer Report, i.e. any endpoint beginning with <c>/cra/</c>), the <c>account_id</c> returned will not match the <c>account_id</c> returned by a non-CRA endpoint.
    /// </para>
    /// <para>
    /// Like all Plaid identifiers, the <c>account_id</c> is case sensitive.
    /// </para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// A set of fields describing the balance for an account. For real-time values, use <c>/accounts/balance/get</c> or <c>/signal/evaluate</c> (with a Balance-only ruleset), which are fetched live from the institution at request time. Values returned by other endpoints may be cached, or adjusted by Plaid to reflect transaction activity received since the last refresh.
    /// </summary>
    [JsonPropertyName("balances")]
    public required AccountBalance Balances { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of either the account's displayed mask or the account's official account number. Note that the mask may be non-unique between an Item's accounts.
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
    /// Indicates an Item's micro-deposit-based verification or database verification status. This field is only populated when using Auth and falling back to micro-deposit or database verification. Possible values are:
    /// <para>
    /// <c>pending_automatic_verification</c>: The Item is pending automatic verification.
    /// </para>
    /// <para>
    /// <c>pending_manual_verification</c>: The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the code.
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
    /// <c>unsent</c>: The Item is pending micro-deposit verification, but Plaid has not yet sent the micro-deposit.
    /// </para>
    /// <para>
    /// <c>database_insights_fail</c>: The Item's numbers have been verified using Plaid's data sources and have signal for being invalid and/or have no signal for being valid. Typically this indicates that the routing number is invalid, the account number does not match the account number format associated with the routing number, or the account has been reported as closed or frozen. Only returned for Auth Items created via Database Auth.
    /// </para>
    /// <para>
    /// <c>database_insights_pass</c>: The Item's numbers have been verified using Plaid's data sources: the routing and account number match a routing and account number of an account recognized on the Plaid network, and the account is not known by Plaid to be frozen or closed. Only returned for Auth Items created via Database Auth.
    /// </para>
    /// <para>
    /// <c>database_insights_pass_with_caution</c>: The Item's numbers have been verified using Plaid's data sources and have some signal for being valid: the routing and account number were not recognized on the Plaid network, but the routing number is valid and the account number is a potential valid account number for that routing number. Only returned for Auth Items created via Database Auth.
    /// </para>
    /// <para>
    /// <c>database_matched</c>: (deprecated) The Item has successfully been verified using Plaid's data sources. Only returned for Auth Items created via Database Match.
    /// </para>
    /// <para>
    /// <c>null</c> or empty string: Neither micro-deposit-based verification nor database verification are being used for the Item.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_status")]
    public VerificationStatus5? VerificationStatus { get; init; }

    /// <summary>
    /// The account holder name that was used for micro-deposit and/or database verification. Only returned for Auth Items created via micro-deposit or database verification. This name was manually-entered by the user during Link, unless it was otherwise provided via the <c>user.legal_name</c> request field in <c>/link/token/create</c> for the Link session that created the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_name")]
    public string? VerificationName { get; init; }

    /// <summary>
    /// Insights from performing database verification for the account. Only returned for Auth Items using Database Auth.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_insights")]
    public VerificationInsights? VerificationInsights { get; init; }

    /// <summary>
    /// A unique and persistent identifier for accounts that can be used to trace multiple instances of the same account across different Items for depository accounts. This field is currently supported only for Items at institutions that use Tokenized Account Numbers (i.e., Chase, PNC, and US Bank). Because these accounts have a different account number each time they are linked, this field may be used instead of the account number to uniquely identify an account across multiple Items for payments use cases, helping to reduce duplicate Items or attempted fraud. In Sandbox, this field is populated for TAN-based institutions (<c>ins_56</c>, <c>ins_13</c>, <c>ins_127990</c>) as well as the OAuth Sandbox institution (<c>ins_127287</c>); in Production, it will only be populated for accounts at applicable institutions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("persistent_account_id")]
    public string? PersistentAccountId { get; init; }

    /// <summary>
    /// Indicates the account's categorization as either a personal or a business account. This field is currently in beta; to request access, contact your account manager.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holder_category")]
    public HolderCategory? HolderCategory { get; init; }

    /// <summary>
    /// Data returned by the financial institution about the account owner or owners. For business accounts, the name reported may be either the name of the individual or the name of the business, depending on the institution. Multiple owners on a single account will be represented in the same owner object, not in multiple owner objects within the array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owners")]
    public IReadOnlyList<Owner>? Owners { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
