using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the repayment plan for the student loan
/// </summary>
public record StudentRepaymentPlan
{
    /// <summary>
    /// The description of the repayment plan as provided by the servicer.
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// The type of the repayment plan.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type3? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
