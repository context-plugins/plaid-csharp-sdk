using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The attributes object contains data that can be used to assess account risk. Examples of data include:
/// <c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid
/// <c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days
/// <c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days
/// <c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid
/// For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact sales or your Plaid account manager
/// </summary>
public record BeaconAccountRiskAttributes
{
    /// <summary>
    /// The number of days since the first time the Item was connected to an application via Plaid
    /// </summary>
    [JsonPropertyName("days_since_first_plaid_connection")]
    public required int? DaysSinceFirstPlaidConnection { get; init; }

    /// <summary>
    /// Indicates if the account has been closed by the financial institution or the consumer, or is at risk of being closed
    /// </summary>
    [JsonPropertyName("is_account_closed")]
    public required bool? IsAccountClosed { get; init; }

    /// <summary>
    /// Indicates whether the account has withdrawals and transfers disabled or if access to the account is restricted. This could be due to a freeze by the credit issuer, legal restrictions (e.g., sanctions), or regulatory requirements limiting monthly withdrawals, among other reasons
    /// </summary>
    [JsonPropertyName("is_account_frozen_or_restricted")]
    public required bool? IsAccountFrozenOrRestricted { get; init; }

    /// <summary>
    /// The total number of times the Item has been connected to applications via Plaid
    /// </summary>
    [JsonPropertyName("total_plaid_connections_count")]
    public required int? TotalPlaidConnectionsCount { get; init; }

    /// <summary>
    /// The number of times the Item has been connected to applications via Plaid over the past 7 days
    /// </summary>
    [JsonPropertyName("plaid_connections_count_7d")]
    public required int? PlaidConnectionsCount7D { get; init; }

    /// <summary>
    /// The number of times the Item has been connected to applications via Plaid over the past 30 days
    /// </summary>
    [JsonPropertyName("plaid_connections_count_30d")]
    public required int? PlaidConnectionsCount30D { get; init; }

    /// <summary>
    /// The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 3 days
    /// </summary>
    [JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_3d")]
    public required int? FailedPlaidNonOauthAuthenticationAttemptsCount3D { get; init; }

    /// <summary>
    /// The number of non-OAuth authentication attempts via Plaid for this bank account over the past 3 days
    /// </summary>
    [JsonPropertyName("plaid_non_oauth_authentication_attempts_count_3d")]
    public required int? PlaidNonOauthAuthenticationAttemptsCount3D { get; init; }

    /// <summary>
    /// The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 7 days
    /// </summary>
    [JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_7d")]
    public required int? FailedPlaidNonOauthAuthenticationAttemptsCount7D { get; init; }

    /// <summary>
    /// The number of non-OAuth authentication attempts via Plaid for this bank account over the past 7 days
    /// </summary>
    [JsonPropertyName("plaid_non_oauth_authentication_attempts_count_7d")]
    public required int? PlaidNonOauthAuthenticationAttemptsCount7D { get; init; }

    /// <summary>
    /// The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 30 days
    /// </summary>
    [JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_30d")]
    public required int? FailedPlaidNonOauthAuthenticationAttemptsCount30D { get; init; }

    /// <summary>
    /// The number of non-OAuth authentication attempts via Plaid for this bank account over the past 30 days
    /// </summary>
    [JsonPropertyName("plaid_non_oauth_authentication_attempts_count_30d")]
    public required int? PlaidNonOauthAuthenticationAttemptsCount30D { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 3 days
    /// </summary>
    [JsonPropertyName("distinct_ip_addresses_count_3d")]
    public required int? DistinctIpAddressesCount3D { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 7 days
    /// </summary>
    [JsonPropertyName("distinct_ip_addresses_count_7d")]
    public required int? DistinctIpAddressesCount7D { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 30 days
    /// </summary>
    [JsonPropertyName("distinct_ip_addresses_count_30d")]
    public required int? DistinctIpAddressesCount30D { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 90 days
    /// </summary>
    [JsonPropertyName("distinct_ip_addresses_count_90d")]
    public required int? DistinctIpAddressesCount90D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 3 days
    /// </summary>
    [JsonPropertyName("distinct_user_agents_count_3d")]
    public required int? DistinctUserAgentsCount3D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 7 days
    /// </summary>
    [JsonPropertyName("distinct_user_agents_count_7d")]
    public required int? DistinctUserAgentsCount7D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 30 days
    /// </summary>
    [JsonPropertyName("distinct_user_agents_count_30d")]
    public required int? DistinctUserAgentsCount30D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 90 days
    /// </summary>
    [JsonPropertyName("distinct_user_agents_count_90d")]
    public required int? DistinctUserAgentsCount90D { get; init; }

    /// <summary>
    /// The number of times the account's addresses on file have changed over the past 28 days
    /// </summary>
    [JsonPropertyName("address_change_count_28d")]
    public required int? AddressChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's email addresses on file have changed over the past 28 days
    /// </summary>
    [JsonPropertyName("email_change_count_28d")]
    public required int? EmailChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's phone numbers on file have changed over the past 28 days
    /// </summary>
    [JsonPropertyName("phone_change_count_28d")]
    public required int? PhoneChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's addresses on file have changed over the past 90 days
    /// </summary>
    [JsonPropertyName("address_change_count_90d")]
    public required int? AddressChangeCount90D { get; init; }

    /// <summary>
    /// The number of times the account's email addresses on file have changed over the past 90 days
    /// </summary>
    [JsonPropertyName("email_change_count_90d")]
    public required int? EmailChangeCount90D { get; init; }

    /// <summary>
    /// The number of times the account's phone numbers on file have changed over the past 90 days
    /// </summary>
    [JsonPropertyName("phone_change_count_90d")]
    public required int? PhoneChangeCount90D { get; init; }

    /// <summary>
    /// The number of days since the bank account was opened, as reported by the financial institution
    /// </summary>
    [JsonPropertyName("days_since_account_opening")]
    public required int? DaysSinceAccountOpening { get; init; }

    /// <summary>
    /// The number of days since the oldest transaction available to Plaid for this account. This measure, combined with Plaid connection history, can be used to infer the age of the account
    /// </summary>
    [JsonPropertyName("days_since_first_observed_transaction")]
    public required int? DaysSinceFirstObservedTransaction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
