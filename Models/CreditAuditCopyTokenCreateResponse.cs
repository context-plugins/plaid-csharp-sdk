using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditAuditCopyTokenCreateResponse defines the response schema for <c>/credit/audit_copy_token/create</c>
/// </summary>
public record CreditAuditCopyTokenCreateResponse
{
    /// <summary>
    /// A token that can be shared with a third party auditor, which allows them to fetch the Asset Reports attached to the token. This token should be stored securely.
    /// </summary>
    [JsonPropertyName("audit_copy_token")]
    public required string AuditCopyToken { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
