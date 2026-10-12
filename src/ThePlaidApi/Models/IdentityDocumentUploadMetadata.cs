using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata pertaining to the document.
/// </summary>
public record IdentityDocumentUploadMetadata
{
    /// <summary>
    /// The submitted document type. Currently, this will always be <c>BANK_STATEMENT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_type")]
    public string? DocumentType { get; init; }

    /// <summary>
    /// Boolean field indicating whether the uploaded document's account number matches the account number we have on file. If <c>false</c>, it is not recommended to accept the uploaded identity data as accurate without further verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_account_number_match")]
    public bool? IsAccountNumberMatch { get; init; }

    /// <summary>
    /// The number of pages in the uploaded document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page_count")]
    public int? PageCount { get; init; }

    /// <summary>
    /// The timestamp when the document was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_updated")]
    public DateTimeOffset? LastUpdated { get; init; }

    /// <summary>
    /// The timestamp when the document was originally uploaded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uploaded_at")]
    public DateTimeOffset? UploadedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
