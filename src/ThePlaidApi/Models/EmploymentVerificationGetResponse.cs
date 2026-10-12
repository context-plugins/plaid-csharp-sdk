using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// EmploymentVerificationGetResponse defines the response schema for <c>/employment/verification/get</c>.
/// </summary>
public record EmploymentVerificationGetResponse
{
    /// <summary>
    /// A list of employment verification summaries.
    /// </summary>
    [JsonPropertyName("employments")]
    public required IReadOnlyList<EmploymentVerification> Employments { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
