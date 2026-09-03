using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorTokenPermissionsGetResponse defines the response schema for <c>/processor/token/permissions/get</c>
/// </summary>
public record ProcessorTokenPermissionsGetResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A list of products the processor token should have access to. An empty list means that the processor has access to all available products, including future products.
    /// </summary>
    [JsonPropertyName("products")]
    public required IReadOnlyList<Products> Products { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
