using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Images, extracted data, and analysis from a user's identity document
/// </summary>
public record DocumentaryVerificationDocument
{
    /// <summary>
    /// An outcome status for this specific document submission. Distinct from the overall <c>documentary_verification.status</c> that summarizes the verification outcome from one or more documents.
    /// </summary>
    [JsonPropertyName("status")]
    public required DocumentStatus Status { get; init; }

    /// <summary>
    /// The <c>attempt</c> field begins with 1 and increments with each subsequent document upload.
    /// </summary>
    [JsonPropertyName("attempt")]
    public required int Attempt { get; init; }

    /// <summary>
    /// URLs for downloading original and cropped images for this document submission. The URLs are designed to only allow downloading, not hot linking, so the URL will only serve the document image for 60 seconds before expiring. The expiration time is 60 seconds after the <c>GET</c> request for the associated Identity Verification attempt. A new expiring URL is generated with each request, so you can always rerequest the Identity Verification attempt if one of your URLs expires.
    /// </summary>
    [JsonPropertyName("images")]
    public required PhysicalDocumentImages Images { get; init; }

    /// <summary>
    /// Data extracted from a user-submitted document.
    /// </summary>
    [JsonPropertyName("extracted_data")]
    public required PhysicalDocumentExtractedData? ExtractedData { get; init; }

    /// <summary>
    /// High level descriptions of how the associated document was processed. If a document fails verification, the details in the <c>analysis</c> object should help clarify why the document was rejected.
    /// </summary>
    [JsonPropertyName("analysis")]
    public required DocumentAnalysis Analysis { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("redacted_at")]
    public required DateTimeOffset? RedactedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
