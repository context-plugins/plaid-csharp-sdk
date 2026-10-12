using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxItemApplicationSeedResponse defines the response schema for <c>/sandbox/item/application/seed</c>
/// </summary>
public record SandboxItemApplicationSeedResponse
{
    /// <summary>
    /// The <c>item_id</c> of the newly seeded item representing the application connection.
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
