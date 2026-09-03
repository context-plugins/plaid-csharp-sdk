using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Describes the last time each datatype was accessed by an application.
/// </summary>
public record LastDataAccessTimes
{
    /// <summary>
    /// ID of the application accessing data.
    /// </summary>
    [JsonPropertyName("application_id")]
    public required string ApplicationId { get; init; }

    /// <summary>
    /// The last time <c>account_balance_info</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("account_balance_info")]
    public required DateTimeOffset? AccountBalanceInfo { get; init; }

    /// <summary>
    /// The last time <c>account_routing_number</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("account_routing_number")]
    public required DateTimeOffset? AccountRoutingNumber { get; init; }

    /// <summary>
    /// The last time <c>contact_details</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("contact_details")]
    public required DateTimeOffset? ContactDetails { get; init; }

    /// <summary>
    /// The last time <c>transactions</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required DateTimeOffset? Transactions { get; init; }

    /// <summary>
    /// The last time <c>credit_and_loans</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("credit_and_loans")]
    public required DateTimeOffset? CreditAndLoans { get; init; }

    /// <summary>
    /// The last time <c>investments</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("investments")]
    public required DateTimeOffset? Investments { get; init; }

    /// <summary>
    /// The last time <c>payroll_info</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("payroll_info")]
    public required DateTimeOffset? PayrollInfo { get; init; }

    /// <summary>
    /// The last time <c>transaction_risk_info</c> was accessed by this application in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC. null if never accessed.
    /// </summary>
    [JsonPropertyName("transaction_risk_info")]
    public required DateTimeOffset? TransactionRiskInfo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
