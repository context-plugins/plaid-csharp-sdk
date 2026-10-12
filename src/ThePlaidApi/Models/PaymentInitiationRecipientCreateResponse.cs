using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationRecipientCreateResponse defines the response schema for <c>/payment_initiation/recipient/create</c>
/// </summary>
public record PaymentInitiationRecipientCreateResponse
{
    /// <summary>
    /// A unique ID identifying the recipient
    /// </summary>
    [JsonPropertyName("recipient_id")]
    public required string RecipientId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
