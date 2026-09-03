using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// RiskProfile is deprecated, use <c>ruleset</c> instead.
/// </summary>
public record SignalEvaluateRiskProfile
{
    /// <summary>
    /// The key of the risk profile used for this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// Legacy method of inspecting the result of the ruleset. New integrations should simply use the "result" property instead. This value will be omitted if you do not have a live existing integration with rules using this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outcome")]
    public string? Outcome { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
