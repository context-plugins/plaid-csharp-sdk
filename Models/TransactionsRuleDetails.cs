using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of transactions rule details.
/// </summary>
public record TransactionsRuleDetails
{
    /// <summary>
    /// Transaction field for which the rule is defined.
    /// </summary>
    [JsonPropertyName("field")]
    public required TransactionsRuleField Field { get; init; }

    /// <summary>
    /// Transaction rule's match type. For <c>TRANSACTION_ID</c> field, <c>EXACT_MATCH</c> is available.
    /// Matches are case sensitive.
    /// </summary>
    [JsonPropertyName("type")]
    public required TransactionsRuleType Type { get; init; }

    /// <summary>
    /// For <c>TRANSACTION_ID</c> field, provide <c>transaction_id</c>. For <c>MERCHANT_NAME</c> field, provide a string pattern.
    /// </summary>
    [JsonPropertyName("query")]
    public required string Query { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
