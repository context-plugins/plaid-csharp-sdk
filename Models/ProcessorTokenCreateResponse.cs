using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorTokenCreateResponse defines the response schema for <c>/processor/token/create</c> and <c>/processor/apex/processor_token/create</c>
/// </summary>
public record ProcessorTokenCreateResponse
{
    /// <summary>
    /// The <c>processor_token</c> that can then be used by the Plaid partner to make API requests
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
