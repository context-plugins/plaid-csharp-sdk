using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying values for network attributes of risk check.
/// </summary>
public record RiskCheckNetwork
{
    /// <summary>
    /// Risk level for the given risk check type.
    /// </summary>
    [JsonPropertyName("risk_level")]
    public required RiskLevel RiskLevel { get; init; }

    /// <summary>
    /// List of factors, when available, that contribute towards the risk level of the given risk check type.
    /// </summary>
    [JsonPropertyName("factors")]
    public required IReadOnlyList<string> Factors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
