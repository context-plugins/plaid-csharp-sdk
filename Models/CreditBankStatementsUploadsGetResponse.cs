using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditBankStatementsUploadsGetResponse defines the response schema for <c>/credit/bank_statements/uploads/get</c>
/// </summary>
public record CreditBankStatementsUploadsGetResponse
{
    /// <summary>
    /// Array of bank statement upload items.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CreditBankStatementUploadItem> Items { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
