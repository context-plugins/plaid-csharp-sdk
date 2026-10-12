using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditEmploymentGetResponse defines the response schema for <c>/credit/employment/get</c>.
/// </summary>
public record CreditEmploymentGetResponse
{
    /// <summary>
    /// Array of employment items.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CreditEmploymentItem> Items { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
