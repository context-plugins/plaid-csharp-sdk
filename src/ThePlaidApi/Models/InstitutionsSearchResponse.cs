using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// InstitutionsSearchResponse defines the response schema for <c>/institutions/search</c>
/// </summary>
public record InstitutionsSearchResponse
{
    /// <summary>
    /// An array of institutions matching the search criteria
    /// </summary>
    [JsonPropertyName("institutions")]
    public required IReadOnlyList<Institution> Institutions { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
