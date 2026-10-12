using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// IdentityDocumentsUploadsGetResponse defines the response schema for <c>/identity/documents/uploads/get</c>
/// </summary>
public record IdentityDocumentsUploadsGetResponse
{
    /// <summary>
    /// The accounts for which Identity data has been requested
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<AccountIdentityDocumentUpload> Accounts { get; init; }

    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
