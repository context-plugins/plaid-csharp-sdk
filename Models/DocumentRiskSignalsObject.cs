using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing fraud risk data for a set of income documents.
/// </summary>
public record DocumentRiskSignalsObject
{
    /// <summary>
    /// ID of the payroll provider account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    /// <summary>
    /// Array of document metadata and associated risk signals per document
    /// </summary>
    [JsonPropertyName("single_document_risk_signals")]
    public required IReadOnlyList<SingleDocumentRiskSignal> SingleDocumentRiskSignals { get; init; }

    /// <summary>
    /// Array of risk signals computed from a set of uploaded documents and the associated documents' metadata
    /// </summary>
    [JsonPropertyName("multi_document_risk_signals")]
    public required IReadOnlyList<MultiDocumentRiskSignal> MultiDocumentRiskSignals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
