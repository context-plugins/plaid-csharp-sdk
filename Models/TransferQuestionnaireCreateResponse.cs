using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/questionnaire/create</c>
/// </summary>
public record TransferQuestionnaireCreateResponse
{
    /// <summary>
    /// Plaid-hosted onboarding URL that you will redirect the end customer to.
    /// </summary>
    [JsonPropertyName("onboarding_url")]
    public required string OnboardingUrl { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
