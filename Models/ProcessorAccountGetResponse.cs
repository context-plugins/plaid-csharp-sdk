using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorAccountGetResponse defines the response schema for <c>/processor/account/get</c>
/// </summary>
public record ProcessorAccountGetResponse
{
    /// <summary>
    /// A single account at a financial institution.
    /// </summary>
    [JsonPropertyName("account")]
    public required Account Account { get; init; }

    /// <summary>
    /// The Plaid Institution ID associated with the Account.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
