using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorLiabilitiesGetResponse defines the response schema for <c>/processor/liabilities/get</c>
/// </summary>
public record ProcessorLiabilitiesGetResponse
{
    /// <summary>
    /// A single account at a financial institution.
    /// </summary>
    [JsonPropertyName("account")]
    public required Account Account { get; init; }

    /// <summary>
    /// An object containing liability accounts
    /// </summary>
    [JsonPropertyName("liabilities")]
    public required LiabilitiesObject Liabilities { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
