using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentListResponse defines the response schema for <c>/payment_initiation/payment/list</c>
/// </summary>
public record PaymentInitiationPaymentListResponse
{
    /// <summary>
    /// An array of payments that have been created, associated with the given <c>client_id</c>.
    /// </summary>
    [JsonPropertyName("payments")]
    public required IReadOnlyList<PaymentInitiationPayment> Payments { get; init; }

    /// <summary>
    /// The value that, when used as the optional <c>cursor</c> parameter to <c>/payment_initiation/payment/list</c>, will return the next unreturned payment as its first payment.
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public required DateTimeOffset? NextCursor { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
