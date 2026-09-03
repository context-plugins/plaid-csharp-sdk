using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The core attributes object contains additional data that can be used to assess the ACH return risk.
/// <para>
/// If using a Balance-only ruleset, only <c>available_balance</c> and <c>current_balance</c> will be returned as core attributes. If using a Signal Transaction Scores ruleset, over 80 core attributes will be returned. Examples of attributes include:
/// </para>
/// <para>
/// <c>available_balance</c> and <c>current_balance</c>: The balance in the ACH transaction funding account
/// <c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid
/// <c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days
/// <c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days
/// <c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid
/// <c>is_savings_or_money_market_account</c>: Indicates whether the ACH transaction funding account is a savings/money market account
/// </para>
/// <para>
/// For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact sales or your Plaid account manager.
/// </para>
/// </summary>
public record SignalEvaluateCoreAttributes
{
    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 7 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_7d")]
    public int? UnauthorizedTransactionsCount7D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 30 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_30d")]
    public int? UnauthorizedTransactionsCount30D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 60 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_60d")]
    public int? UnauthorizedTransactionsCount60D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 90 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_90d")]
    public int? UnauthorizedTransactionsCount90D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 7 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_7d")]
    public int? NsfOverdraftTransactionsCount7D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 30 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_30d")]
    public int? NsfOverdraftTransactionsCount30D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 60 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_60d")]
    public int? NsfOverdraftTransactionsCount60D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 90 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_90d")]
    public int? NsfOverdraftTransactionsCount90D { get; init; }

    /// <summary>
    /// The number of days since the first time the Item was connected to an application via Plaid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_first_plaid_connection")]
    public int? DaysSinceFirstPlaidConnection { get; init; }

    /// <summary>
    /// The number of times the Item has been connected to applications via Plaid over the past 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plaid_connections_count_7d")]
    public int? PlaidConnectionsCount7D { get; init; }

    /// <summary>
    /// The number of times the Item has been connected to applications via Plaid over the past 30 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plaid_connections_count_30d")]
    public int? PlaidConnectionsCount30D { get; init; }

    /// <summary>
    /// The total number of times the Item has been connected to applications via Plaid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_plaid_connections_count")]
    public int? TotalPlaidConnectionsCount { get; init; }

    /// <summary>
    /// Indicates if the ACH transaction funding account is a savings/money market account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_savings_or_money_market_account")]
    public bool? IsSavingsOrMoneyMarketAccount { get; init; }

    /// <summary>
    /// The total credit (inflow) transaction amount over the past 10 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_credit_transactions_amount_10d")]
    public double? TotalCreditTransactionsAmount10D { get; init; }

    /// <summary>
    /// The total debit (outflow) transaction amount over the past 10 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_debit_transactions_amount_10d")]
    public double? TotalDebitTransactionsAmount10D { get; init; }

    /// <summary>
    /// The 50th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_credit_transactions_amount_28d")]
    public double? P50CreditTransactionsAmount28D { get; init; }

    /// <summary>
    /// The 50th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_debit_transactions_amount_28d")]
    public double? P50DebitTransactionsAmount28D { get; init; }

    /// <summary>
    /// The 95th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p95_credit_transactions_amount_28d")]
    public double? P95CreditTransactionsAmount28D { get; init; }

    /// <summary>
    /// The 95th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p95_debit_transactions_amount_28d")]
    public double? P95DebitTransactionsAmount28D { get; init; }

    /// <summary>
    /// The number of days within the past 90 days when the account that will be debited had a negative end-of-day available balance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_with_negative_balance_count_90d")]
    public int? DaysWithNegativeBalanceCount90D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance over the past 30 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_30d")]
    public double? P90EodBalance30D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_60d")]
    public double? P90EodBalance60D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_90d")]
    public double? P90EodBalance90D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance over the past 30 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_30d")]
    public double? P10EodBalance30D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_60d")]
    public double? P10EodBalance60D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_90d")]
    public double? P10EodBalance90D { get; init; }

    /// <summary>
    /// Available balance, as of the <c>balance_last_updated</c> time. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_balance")]
    public double? AvailableBalance { get; init; }

    /// <summary>
    /// Current balance, as of the <c>balance_last_updated</c> time. The current balance is the total amount of funds in the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_balance")]
    public double? CurrentBalance { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the balance for the given account has been updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance_last_updated")]
    public DateTimeOffset? BalanceLastUpdated { get; init; }

    /// <summary>
    /// The number of times the account's phone numbers on file have changed over the past 28 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_change_count_28d")]
    public int? PhoneChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's phone numbers on file have changed over the past 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_change_count_90d")]
    public int? PhoneChangeCount90D { get; init; }

    /// <summary>
    /// The number of times the account's email addresses on file have changed over the past 28 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_change_count_28d")]
    public int? EmailChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's email addresses on file have changed over the past 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_change_count_90d")]
    public int? EmailChangeCount90D { get; init; }

    /// <summary>
    /// The number of times the account's addresses on file have changed over the past 28 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_change_count_28d")]
    public int? AddressChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's addresses on file have changed over the past 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_change_count_90d")]
    public int? AddressChangeCount90D { get; init; }

    /// <summary>
    /// The number of non-OAuth authentication attempts via Plaid for this bank account over the past 3 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plaid_non_oauth_authentication_attempts_count_3d")]
    public int? PlaidNonOauthAuthenticationAttemptsCount3D { get; init; }

    /// <summary>
    /// The number of non-OAuth authentication attempts via Plaid for this bank account over the past 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plaid_non_oauth_authentication_attempts_count_7d")]
    public int? PlaidNonOauthAuthenticationAttemptsCount7D { get; init; }

    /// <summary>
    /// The number of non-OAuth authentication attempts via Plaid for this bank account over the past 30 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plaid_non_oauth_authentication_attempts_count_30d")]
    public int? PlaidNonOauthAuthenticationAttemptsCount30D { get; init; }

    /// <summary>
    /// The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 3 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_3d")]
    public int? FailedPlaidNonOauthAuthenticationAttemptsCount3D { get; init; }

    /// <summary>
    /// The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_7d")]
    public int? FailedPlaidNonOauthAuthenticationAttemptsCount7D { get; init; }

    /// <summary>
    /// The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 30 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_30d")]
    public int? FailedPlaidNonOauthAuthenticationAttemptsCount30D { get; init; }

    /// <summary>
    /// The total number of debit (outflow) transactions over the past 10 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit_transactions_count_10d")]
    public int? DebitTransactionsCount10D { get; init; }

    /// <summary>
    /// The total number of credit (inflow) transactions over the past 10 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_transactions_count_10d")]
    public int? CreditTransactionsCount10D { get; init; }

    /// <summary>
    /// The total number of debit (outflow) transactions over the past 30 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit_transactions_count_30d")]
    public int? DebitTransactionsCount30D { get; init; }

    /// <summary>
    /// The total number of credit (inflow) transactions over the past 30 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_transactions_count_30d")]
    public int? CreditTransactionsCount30D { get; init; }

    /// <summary>
    /// The total number of debit (outflow) transactions over the past 60 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit_transactions_count_60d")]
    public int? DebitTransactionsCount60D { get; init; }

    /// <summary>
    /// The total number of credit (inflow) transactions over the past 60 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_transactions_count_60d")]
    public int? CreditTransactionsCount60D { get; init; }

    /// <summary>
    /// The total number of debit (outflow) transactions over the past 90 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit_transactions_count_90d")]
    public int? DebitTransactionsCount90D { get; init; }

    /// <summary>
    /// The total number of credit (inflow) transactions over the past 90 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_transactions_count_90d")]
    public int? CreditTransactionsCount90D { get; init; }

    /// <summary>
    /// The total debit (outflow) transaction amount over the past 30 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_debit_transactions_amount_30d")]
    public double? TotalDebitTransactionsAmount30D { get; init; }

    /// <summary>
    /// The total credit (inflow) transaction amount over the past 30 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_credit_transactions_amount_30d")]
    public double? TotalCreditTransactionsAmount30D { get; init; }

    /// <summary>
    /// The total debit (outflow) transaction amount over the past 60 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_debit_transactions_amount_60d")]
    public double? TotalDebitTransactionsAmount60D { get; init; }

    /// <summary>
    /// The total credit (inflow) transaction amount over the past 60 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_credit_transactions_amount_60d")]
    public double? TotalCreditTransactionsAmount60D { get; init; }

    /// <summary>
    /// The total debit (outflow) transaction amount over the past 90 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_debit_transactions_amount_90d")]
    public double? TotalDebitTransactionsAmount90D { get; init; }

    /// <summary>
    /// The total credit (inflow) transaction amount over the past 90 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_credit_transactions_amount_90d")]
    public double? TotalCreditTransactionsAmount90D { get; init; }

    /// <summary>
    /// The 50th percentile of the end-of-day available balance over the past 30 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_eod_balance_30d")]
    public double? P50EodBalance30D { get; init; }

    /// <summary>
    /// The 50th percentile of the end-of-day available balance over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_eod_balance_60d")]
    public double? P50EodBalance60D { get; init; }

    /// <summary>
    /// The 50th percentile of the end-of-day available balance over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_eod_balance_90d")]
    public double? P50EodBalance90D { get; init; }

    /// <summary>
    /// The 50th percentile of the end-of-day available balance between day 31 and day 60 over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_eod_balance_31d_to_60d")]
    public double? P50EodBalance31DTo60D { get; init; }

    /// <summary>
    /// The 50th percentile of the end-of-day available balance between day 61 and day 90 over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_eod_balance_61d_to_90d")]
    public double? P50EodBalance61DTo90D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance between day 31 and day 60 over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_31d_to_60d")]
    public double? P90EodBalance31DTo60D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance between day 61 and day 90 over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_61d_to_90d")]
    public double? P90EodBalance61DTo90D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance between day 31 and day 60 over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_31d_to_60d")]
    public double? P10EodBalance31DTo60D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance between day 61 and day 90 over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_61d_to_90d")]
    public double? P10EodBalance61DTo90D { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the transactions for the given account have been updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions_last_updated")]
    public DateTimeOffset? TransactionsLastUpdated { get; init; }

    /// <summary>
    /// Indicates if the account that will be debited is closed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_account_closed")]
    public bool? IsAccountClosed { get; init; }

    /// <summary>
    /// Indicates if the account that will be debited is either frozen or restricted
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_account_frozen_or_restricted")]
    public bool? IsAccountFrozenOrRestricted { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 3 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ip_addresses_count_3d")]
    public int? DistinctIpAddressesCount3D { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ip_addresses_count_7d")]
    public int? DistinctIpAddressesCount7D { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 30 days (max 100)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ip_addresses_count_30d")]
    public int? DistinctIpAddressesCount30D { get; init; }

    /// <summary>
    /// The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 90 days (max 100)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ip_addresses_count_90d")]
    public int? DistinctIpAddressesCount90D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 3 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_user_agents_count_3d")]
    public int? DistinctUserAgentsCount3D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_user_agents_count_7d")]
    public int? DistinctUserAgentsCount7D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 30 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_user_agents_count_30d")]
    public int? DistinctUserAgentsCount30D { get; init; }

    /// <summary>
    /// The number of distinct user agents linked to the same bank account during Plaid authentication in the last 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_user_agents_count_90d")]
    public int? DistinctUserAgentsCount90D { get; init; }

    /// <summary>
    /// The number of distinct SSL/TLS connection sessions linked to the same bank account during Plaid authentication in the last 3 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ssl_tls_connection_sessions_count_3d")]
    public int? DistinctSslTlsConnectionSessionsCount3D { get; init; }

    /// <summary>
    /// The number of distinct SSL/TLS connection sessions linked to the same bank account during Plaid authentication in the last 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ssl_tls_connection_sessions_count_7d")]
    public int? DistinctSslTlsConnectionSessionsCount7D { get; init; }

    /// <summary>
    /// The number of distinct SSL/TLS connection sessions linked to the same bank account during Plaid authentication in the last 30 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ssl_tls_connection_sessions_count_30d")]
    public int? DistinctSslTlsConnectionSessionsCount30D { get; init; }

    /// <summary>
    /// The number of distinct SSL/TLS connection sessions linked to the same bank account during Plaid authentication in the last 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distinct_ssl_tls_connection_sessions_count_90d")]
    public int? DistinctSslTlsConnectionSessionsCount90D { get; init; }

    /// <summary>
    /// The number of days since the bank account was opened, as reported by the financial institution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_account_opening")]
    public int? DaysSinceAccountOpening { get; init; }

    /// <summary>
    /// Taking <c>available_or_current_balance</c> and dividing it by the transaction amount. Useful to say "10% buffer", for example. This is a convenience function to build Signal Rules upon.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance_to_transaction_amount_ratio")]
    public double? BalanceToTransactionAmountRatio { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
