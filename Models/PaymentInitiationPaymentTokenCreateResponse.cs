using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentTokenCreateResponse defines the response schema for <c>/payment_initiation/payment/token/create</c>
/// </summary>
public record PaymentInitiationPaymentTokenCreateResponse
{
    /// <summary>
    /// A <c>payment_token</c> that can be provided to Link initialization to enter the payment initiation flow
    /// </summary>
    [JsonPropertyName("payment_token")]
    public required string PaymentToken { get; init; }

    /// <summary>
    /// The date and time at which the token will expire, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format. A <c>payment_token</c> expires after 15 minutes.
    /// </summary>
    [JsonPropertyName("payment_token_expiration_time")]
    public required DateTimeOffset PaymentTokenExpirationTime { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
