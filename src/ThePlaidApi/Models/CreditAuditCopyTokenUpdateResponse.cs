using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/credit/audit_copy_token/update</c>
/// </summary>
public record CreditAuditCopyTokenUpdateResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// <c>true</c> if the Audit Copy Token was successfully updated.
    /// </summary>
    [JsonPropertyName("updated")]
    public required bool Updated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
