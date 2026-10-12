using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentReverseRequest defines the request schema for <c>/payment_initiation/payment/reverse</c>
/// </summary>
public record PaymentInitiationPaymentReverseRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The ID of the payment to reverse
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// A random key provided by the client, per unique wallet transaction. Maximum of 128 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a wallet transaction fails due to a network connection error, then after a minimum delay of one minute, you can retry the request with the same idempotency key to guarantee that only a single wallet transaction is created. If the request was successfully processed, it will prevent any transaction that uses the same idempotency key, and was received within 24 hours of the first request, from being processed.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// A reference for the refund. This must be an alphanumeric string with 6 to 18 characters and must not contain any special characters or spaces.
    /// </summary>
    [JsonPropertyName("reference")]
    [StringLength(18, MinimumLength = 6)]
    public required string Reference { get; init; }

    /// <summary>
    /// The amount and currency of a payment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public PaymentAmountToRefund? Amount { get; init; }

    /// <summary>
    /// The counterparty's birthdate, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty_date_of_birth")]
    public DateTimeOffset? CounterpartyDateOfBirth { get; init; }

    /// <summary>
    /// The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty_address")]
    public PaymentInitiationAddress? CounterpartyAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
