using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// InstitutionsGetByIdResponse defines the response schema for <c>/institutions/get_by_id</c>
/// </summary>
public record InstitutionsGetByIdResponse
{
    /// <summary>
    /// Details relating to a specific financial institution
    /// </summary>
    [JsonPropertyName("institution")]
    public required Institution Institution { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
