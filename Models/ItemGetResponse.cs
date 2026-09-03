using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ItemGetResponse defines the response schema for <c>/item/get</c> and <c>/item/webhook/update</c>
/// </summary>
public record ItemGetResponse
{
    /// <summary>
    /// Metadata about the Item
    /// </summary>
    [JsonPropertyName("item")]
    public required ItemWithConsentFields Item { get; init; }

    /// <summary>
    /// An object with information about the status of the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public ItemStatusNullable? Status { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
