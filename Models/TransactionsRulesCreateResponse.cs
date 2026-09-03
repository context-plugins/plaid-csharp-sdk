using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRulesCreateResponse defines the response schema for <c>/beta/transactions/rules/v1/create</c>
/// </summary>
public record TransactionsRulesCreateResponse
{
    /// <summary>
    /// A representation of a transactions category rule.
    /// </summary>
    [JsonPropertyName("rule")]
    public required TransactionsCategoryRule Rule { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
