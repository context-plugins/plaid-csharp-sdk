using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Document object with metadata of the uploaded document
/// </summary>
public record IdentityDocumentUpload
{
    /// <summary>
    /// A UUID identifying the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_id")]
    public string? DocumentId { get; init; }

    /// <summary>
    /// Metadata pertaining to the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IdentityDocumentUploadMetadata? Metadata { get; init; }

    /// <summary>
    /// Object representing fraud risk data of the uploaded document. Only provided when using Identity Document Upload with Fraud Risk enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_insights")]
    public IdentityDocumentUploadRiskInsights? RiskInsights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
