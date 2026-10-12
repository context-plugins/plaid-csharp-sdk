using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// IncomeVerificationCreateResponse defines the response schema for <c>/income/verification/create</c>.
/// </summary>
public record IncomeVerificationCreateResponse
{
    /// <summary>
    /// ID of the verification. This ID is persisted throughout the lifetime of the verification.
    /// </summary>
    [JsonPropertyName("income_verification_id")]
    public required string IncomeVerificationId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
