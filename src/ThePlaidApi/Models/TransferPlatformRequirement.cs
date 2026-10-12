using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A piece of information that is required for originator onboarding.
/// </summary>
public record TransferPlatformRequirement
{
    /// <summary>
    /// The type of requirement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirement_type")]
    public string? RequirementType { get; init; }

    /// <summary>
    /// UUID of the person associated with the requirement. Only present for individual-scoped requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("person_id")]
    public string? PersonId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
