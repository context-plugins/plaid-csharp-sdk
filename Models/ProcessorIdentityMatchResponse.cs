using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorIdentityMatchResponse defines the response schema for <c>/processor/identity/match</c>
/// </summary>
public record ProcessorIdentityMatchResponse
{
    /// <summary>
    /// Identity match scores for an account
    /// </summary>
    [JsonPropertyName("account")]
    public required AccountIdentityMatchScore Account { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
