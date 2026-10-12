using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing all risk signals and relevant metadata for a single document
/// </summary>
public record SingleDocumentRiskSignal
{
    /// <summary>
    /// Object containing metadata for the document
    /// </summary>
    [JsonPropertyName("document_reference")]
    public required RiskSignalDocumentReference DocumentReference { get; init; }

    /// <summary>
    /// Array of attributes that indicate whether or not there is fraud risk with a document
    /// </summary>
    [JsonPropertyName("risk_signals")]
    public required IReadOnlyList<DocumentRiskSignal?> RiskSignals { get; init; }

    /// <summary>
    /// A summary across all risk signals associated with a document
    /// </summary>
    [JsonPropertyName("risk_summary")]
    public required DocumentRiskSummary RiskSummary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
