using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorSignalEvaluateResponse defines the response schema for <c>/processor/signal/evaluate</c>
/// </summary>
public record ProcessorSignalEvaluateResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// Risk scoring details broken down by risk category. When using a Balance-only ruleset, this object will not be returned.
    /// </summary>
    [JsonPropertyName("scores")]
    public required SignalEvaluateScores? Scores { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("core_attributes")]
    public SignalEvaluateCoreAttributes? CoreAttributes { get; init; }

    /// <summary>
    /// Details about the transaction result after evaluation by the requested Ruleset. If a <c>ruleset_key</c> is not provided, for customers who began using Signal Transaction Scores before October 15, 2025, by default, this field will be omitted. To learn more, see <see href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleset")]
    public SignalEvaluateRuleset? Ruleset { get; init; }

    /// <summary>
    /// If bank information was not available to be used in the Signal Transaction Scores model, this array contains warnings describing why bank data is missing. If you want to receive an API error instead of scores in the case of missing bank data, file a support ticket or contact your Plaid account manager.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<SignalWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
