using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing metadata for the document
/// </summary>
public record RiskSignalDocumentReference
{
    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_id")]
    public string? DocumentId { get; init; }

    /// <summary>
    /// The name of the document
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_name")]
    public string? DocumentName { get; init; }

    /// <summary>
    /// Status of a document for risk signal analysis
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public RiskSignalDocumentStatus? Status { get; init; }

    /// <summary>
    /// Type of a document for risk signal analysis
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_type")]
    public RiskSignalDocumentType? DocumentType { get; init; }

    /// <summary>
    /// The file type for risk signal analysis
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file_type")]
    public RiskSignalFileType? FileType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
