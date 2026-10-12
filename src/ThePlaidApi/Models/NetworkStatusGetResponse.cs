using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// NetworkStatusGetResponse defines the response schema for <c>/network/status/get</c>
/// </summary>
public record NetworkStatusGetResponse
{
    /// <summary>
    /// Enum representing the overall network status of the user.
    /// </summary>
    [JsonPropertyName("network_status")]
    public required NetworkStatusGetResponseNetworkStatus NetworkStatus { get; init; }

    /// <summary>
    /// An object representing Layer-related metadata for the requested user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("layer")]
    public NetworkStatusGetResponseLayer? Layer { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
