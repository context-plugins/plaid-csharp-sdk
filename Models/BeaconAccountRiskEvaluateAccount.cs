using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An account in the <c>/beacon/account_risk/v1/evaluate</c> response.
/// </summary>
public record BeaconAccountRiskEvaluateAccount
{
    /// <summary>
    /// The account ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

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

    /// <summary>
    /// The attributes object contains data that can be used to assess account risk. Examples of data include:
    /// <c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid
    /// <c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days
    /// <c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days
    /// <c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid
    /// For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact sales or your Plaid account manager
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public BeaconAccountRiskEvaluateAccountAttributes? Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
