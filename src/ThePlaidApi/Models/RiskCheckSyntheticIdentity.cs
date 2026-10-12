using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Field containing the data used in determining the outcome of the synthetic identity risk check.
/// <para>
/// Contains the following fields:
/// </para>
/// <para>
/// <c>score</c> - A score from 0 to 100 indicating the likelihood that the user is a synthetic identity.
/// </para>
/// </summary>
public record RiskCheckSyntheticIdentity
{
    /// <summary>
    /// A score from 0 to 100 indicating the likelihood that the user is a synthetic identity.
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    /// <summary>
    /// Risk level for the given risk check type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_level")]
    public RiskLevel? RiskLevel { get; init; }

    /// <summary>
    /// Field containing the data used in determining the outcome of a synthetic fraud risk check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first_party_synthetic_fraud")]
    public SyntheticFraud? FirstPartySyntheticFraud { get; init; }

    /// <summary>
    /// Field containing the data used in determining the outcome of a synthetic fraud risk check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("third_party_synthetic_fraud")]
    public SyntheticFraud? ThirdPartySyntheticFraud { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
