using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// StatementsListResponse defines the response schema for <c>/statements/list</c>
/// </summary>
public record StatementsListResponse
{
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<StatementsAccount> Accounts { get; init; }

    /// <summary>
    /// The Plaid Institution ID associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The name of the institution associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_name")]
    public required string InstitutionName { get; init; }

    /// <summary>
    /// The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
