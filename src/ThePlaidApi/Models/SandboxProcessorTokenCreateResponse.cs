using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxProcessorTokenCreateResponse defines the response schema for <c>/sandbox/processor_token/create</c>
/// </summary>
public record SandboxProcessorTokenCreateResponse
{
    /// <summary>
    /// A processor token that can be used to call the <c>/processor/</c> endpoints.
    /// </summary>
    [JsonPropertyName("processor_token")]
    public required string ProcessorToken { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
