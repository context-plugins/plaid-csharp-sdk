using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing risk signals and relevant metadata for a set of uploaded documents
/// </summary>
public record MultiDocumentRiskSignal
{
    /// <summary>
    /// Array of objects containing attributes that could indicate if a document is fraudulent
    /// </summary>
    [JsonPropertyName("document_references")]
    public required IReadOnlyList<RiskSignalDocumentReference> DocumentReferences { get; init; }

    /// <summary>
    /// Array of attributes that indicate whether or not there is fraud risk with a set of documents
    /// </summary>
    [JsonPropertyName("risk_signals")]
    public required IReadOnlyList<DocumentRiskSignal> RiskSignals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
