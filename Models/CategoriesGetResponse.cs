using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CategoriesGetResponse defines the response schema for <c>/categories/get</c>
/// </summary>
public record CategoriesGetResponse
{
    /// <summary>
    /// An array of all of the transaction categories used by Plaid.
    /// </summary>
    [JsonPropertyName("categories")]
    public required IReadOnlyList<Category> Categories { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
