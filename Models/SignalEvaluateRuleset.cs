using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the transaction result after evaluation by the requested Ruleset. If a <c>ruleset_key</c> is not provided, for customers who began using Signal Transaction Scores before October 15, 2025, by default, this field will be omitted. To learn more, see <see href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</see>.
/// </summary>
public record SignalEvaluateRuleset
{
    /// <summary>
    /// The key of the Ruleset used for this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleset_key")]
    public string? RulesetKey { get; init; }

    /// <summary>
    /// The result of the rule that was triggered for this transaction.
    /// <para>
    /// <c>ACCEPT</c>: Accept the transaction for processing.
    /// <c>REROUTE</c>: Reroute the transaction to a different payment method, as this transaction is too risky.
    /// <c>REVIEW</c>: Review the transaction before proceeding.
    /// </para>
    /// </summary>
    [JsonPropertyName("result")]
    public required RuleResult Result { get; init; }

    /// <summary>
    /// Rules are run in numerical order. The first rule with a logic match is triggered. These are the details of that rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggered_rule_details")]
    public RuleDetails? TriggeredRuleDetails { get; init; }

    /// <summary>
    /// The evaluated outcome for this transaction. This field is deprecated, use <c>result</c> or <c>triggered_rule_details.custom_action_key</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outcome")]
    public string? Outcome { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
