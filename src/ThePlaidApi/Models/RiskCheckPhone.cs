using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying values for <c>phone</c> attributes of risk check.
/// </summary>
public record RiskCheckPhone
{
    /// <summary>
    /// A list of online services where this phone number has been detected to have accounts or other activity.
    /// </summary>
    [JsonPropertyName("linked_services")]
    [UniqueItems]
    public required IReadOnlyList<RiskCheckLinkedService> LinkedServices { get; init; }

    /// <summary>
    /// Risk level for the given risk check type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_level")]
    public RiskLevel? RiskLevel { get; init; }

    /// <summary>
    /// List of factors, when available, that contribute towards the risk level of the given risk check type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("factors")]
    public IReadOnlyList<string>? Factors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
