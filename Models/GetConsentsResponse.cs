using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// GetConsentsResponse defines the response schema for <c>/fdx/consents</c>
/// </summary>
public record GetConsentsResponse
{
    /// <summary>
    /// Consent grants matching the customerId (and optional status) filter.
    /// </summary>
    [JsonPropertyName("consent_grants")]
    public required IReadOnlyList<FdxConsentGrant> ConsentGrants { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
