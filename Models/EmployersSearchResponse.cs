using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// EmployersSearchResponse defines the response schema for <c>/employers/search</c>.
/// </summary>
public record EmployersSearchResponse
{
    /// <summary>
    /// A list of employers matching the search criteria.
    /// </summary>
    [JsonPropertyName("employers")]
    public required IReadOnlyList<Employer> Employers { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
