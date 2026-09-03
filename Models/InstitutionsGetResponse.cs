using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// InstitutionsGetResponse defines the response schema for <c>/institutions/get</c>
/// </summary>
public record InstitutionsGetResponse
{
    /// <summary>
    /// A list of Plaid institutions
    /// </summary>
    [JsonPropertyName("institutions")]
    public required IReadOnlyList<Institution> Institutions { get; init; }

    /// <summary>
    /// The total number of institutions available via this endpoint
    /// </summary>
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
