using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// LinkOAuthCorrelationIdExchangeResponse defines the response schema for <c>/link/oauth/correlation_id/exchange</c>
/// </summary>
public record LinkOAuthCorrelationIdExchangeResponse
{
    /// <summary>
    /// The <c>link_token</c> associated to the given <c>link_correlation_id</c>, which can be used to re-initialize Link.
    /// </summary>
    [JsonPropertyName("link_token")]
    public required string LinkToken { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
