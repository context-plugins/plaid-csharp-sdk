using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentCreateResponse defines the response schema for <c>/payment_initiation/payment/create</c>
/// </summary>
public record PaymentInitiationPaymentCreateResponse
{
    /// <summary>
    /// A unique ID identifying the payment
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// For a payment returned by this endpoint, there is only one possible value:
    /// <para>
    /// <c>PAYMENT_STATUS_INPUT_NEEDED</c>: The initial phase of the payment
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required PaymentInitiationPaymentCreateStatus Status { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
