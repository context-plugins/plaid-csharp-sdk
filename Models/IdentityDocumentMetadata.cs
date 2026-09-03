using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// In closed beta. Object representing metadata pertaining to the document.
/// </summary>
public record IdentityDocumentMetadata
{
    /// <summary>
    /// Boolean field indicating if the uploaded document's account number matches the account number we have on file
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_account_number_match")]
    public bool? IsAccountNumberMatch { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_updated")]
    public DateTimeOffset? LastUpdated { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uploaded_at")]
    public DateTimeOffset? UploadedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
