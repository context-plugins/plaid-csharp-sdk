using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The results of the LendScore
/// </summary>
public record LendScore
{
    /// <summary>
    /// The score returned by the LendScore model. Will be an integer in the range 1 to 99. Higher scores indicate lower credit risk.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public int? Score { get; init; }

    /// <summary>
    /// The reasons for an individual having risk according to the LendScore. For a full list of possible reason codes and a mapping of reason codes to human-readable reasons, contact your Plaid account manager. Different LendScore versions will use different sets of reason codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_codes")]
    public IReadOnlyList<string>? ReasonCodes { get; init; }

    /// <summary>
    /// Human-readable description of why the LendScore could not be computed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_reason")]
    public string? ErrorReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
