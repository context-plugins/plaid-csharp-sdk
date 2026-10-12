using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying values for <c>behavior</c> attributes of risk check, when available.
/// </summary>
public record RiskCheckBehavior
{
    /// <summary>
    /// Field describing the overall user interaction signals of a behavior risk check. This value represents how familiar the user is with the personal data they provide, based on a number of signals that are collected during their session.
    /// <para>
    /// <c>genuine</c> indicates the user has high familiarity with the data they are providing, and that fraud is unlikely.
    /// </para>
    /// <para>
    /// <c>neutral</c> indicates some signals are present in between <c>risky</c> and <c>genuine</c>, but there are not enough clear signals to determine an outcome.
    /// </para>
    /// <para>
    /// <c>risky</c> indicates the user has low familiarity with the data they are providing, and that fraud is likely.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates there is not sufficient information to give an accurate signal.
    /// </para>
    /// </summary>
    [JsonPropertyName("user_interactions")]
    public required RiskCheckBehaviorUserInteractionsLabel UserInteractions { get; init; }

    /// <summary>
    /// Field describing the outcome of a fraud ring behavior risk check.
    /// <para>
    /// <c>yes</c> indicates that fraud ring activity was detected.
    /// </para>
    /// <para>
    /// <c>no</c> indicates that fraud ring activity was not detected.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates there was not enough information available to give an accurate signal.
    /// </para>
    /// </summary>
    [JsonPropertyName("fraud_ring_detected")]
    public required RiskCheckBehaviorFraudRingDetectedLabel FraudRingDetected { get; init; }

    /// <summary>
    /// Field describing the outcome of a bot detection behavior risk check.
    /// <para>
    /// <c>yes</c> indicates that automated activity was detected.
    /// </para>
    /// <para>
    /// <c>no</c> indicates that automated activity was not detected.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates there was not enough information available to give an accurate signal.
    /// </para>
    /// </summary>
    [JsonPropertyName("bot_detected")]
    public required RiskCheckBehaviorBotDetectedLabel BotDetected { get; init; }

    /// <summary>
    /// Risk level for the given risk check type, when available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_level")]
    public RiskLevelWithNoData? RiskLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
