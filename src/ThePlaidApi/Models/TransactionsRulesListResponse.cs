using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRulesListResponse defines the response schema for <c>/beta/transactions/rules/v1/list</c>
/// </summary>
public record TransactionsRulesListResponse
{
    /// <summary>
    /// A list of the user's transaction rules
    /// </summary>
    [JsonPropertyName("rules")]
    public required IReadOnlyList<TransactionsCategoryRule> Rules { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
