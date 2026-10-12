using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentProfileCreateResponse defines the response schema for <c>/payment_profile/create</c>
/// </summary>
public record PaymentProfileCreateResponse
{
    /// <summary>
    /// A payment profile token associated with the Payment Profile data that is being requested.
    /// </summary>
    [JsonPropertyName("payment_profile_token")]
    public required string PaymentProfileToken { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
