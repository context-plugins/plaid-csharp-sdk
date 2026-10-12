using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/diligence/document/upload</c>
/// </summary>
public record TransferDiligenceDocumentUploadRequest
{
    /// <summary>
    /// The Client ID of the originator whose document that you want to upload.
    /// </summary>
    [JsonPropertyName("originator_client_id")]
    public required string OriginatorClientId { get; init; }

    /// <summary>
    /// A file to upload. The file size must be less than 20MB. Supported file extensions: .pdf.
    /// </summary>
    [JsonPropertyName("file")]
    public required BinaryContent File { get; init; }

    /// <summary>
    /// Specifies the purpose of the uploaded file.
    /// <para>
    /// <c>"DUE_DILIGENCE"</c> - The transfer due diligence document of the originator.
    /// </para>
    /// </summary>
    [JsonPropertyName("purpose")]
    public required Purpose Purpose { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
