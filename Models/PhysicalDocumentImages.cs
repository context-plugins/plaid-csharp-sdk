using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// URLs for downloading original and cropped images for this document submission. The URLs are designed to only allow downloading, not hot linking, so the URL will only serve the document image for 60 seconds before expiring. The expiration time is 60 seconds after the <c>GET</c> request for the associated Identity Verification attempt. A new expiring URL is generated with each request, so you can always rerequest the Identity Verification attempt if one of your URLs expires.
/// </summary>
public record PhysicalDocumentImages
{
    /// <summary>
    /// Temporary URL that expires after 60 seconds for downloading the uncropped original image of the front of the document.
    /// </summary>
    [JsonPropertyName("original_front")]
    public required string? OriginalFront { get; init; }

    /// <summary>
    /// Temporary URL that expires after 60 seconds for downloading the original image of the back of the document. Might be null if the back of the document was not collected.
    /// </summary>
    [JsonPropertyName("original_back")]
    public required string? OriginalBack { get; init; }

    /// <summary>
    /// Temporary URL that expires after 60 seconds for downloading a cropped image containing just the front of the document.
    /// </summary>
    [JsonPropertyName("cropped_front")]
    public required string? CroppedFront { get; init; }

    /// <summary>
    /// Temporary URL that expires after 60 seconds for downloading a cropped image containing just the back of the document. Might be null if the back of the document was not collected.
    /// </summary>
    [JsonPropertyName("cropped_back")]
    public required string? CroppedBack { get; init; }

    /// <summary>
    /// Temporary URL that expires after 60 seconds for downloading a crop of just the user's face from the document image. Might be null if the document does not contain a face photo.
    /// </summary>
    [JsonPropertyName("face")]
    public required string? Face { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
