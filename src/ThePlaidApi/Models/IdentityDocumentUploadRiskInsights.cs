using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object representing fraud risk data of the uploaded document. Only provided when using Identity Document Upload with Fraud Risk enabled.
/// </summary>
public record IdentityDocumentUploadRiskInsights
{
    /// <summary>
    /// Risk summary of an uploaded document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_summary")]
    public IdentityDocumentUploadRiskSummary? RiskSummary { get; init; }

    /// <summary>
    /// An array of risk signals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_signals")]
    public IReadOnlyList<IdentityDocumentUploadRiskSignal>? RiskSignals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
