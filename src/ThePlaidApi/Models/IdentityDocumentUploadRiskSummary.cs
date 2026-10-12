using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Risk summary of an uploaded document.
/// </summary>
public record IdentityDocumentUploadRiskSummary
{
    /// <summary>
    /// A number between 0 and 100, inclusive, where a score closer to 0 indicates a document is likely to be trustworthy and a score closer to 100 indicates a document is likely to be fraudulent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_score")]
    public int? RiskScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
