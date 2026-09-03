using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationConsentPaymentExecuteRequest defines the request schema for <c>/payment_initiation/consent/payment/execute</c>
/// </summary>
public record PaymentInitiationConsentPaymentExecuteRequest
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
    /// The consent ID.
    /// </summary>
    [JsonPropertyName("consent_id")]
    public required string ConsentId { get; init; }

    /// <summary>
    /// The amount and currency of a payment
    /// </summary>
    [JsonPropertyName("amount")]
    public required PaymentAmount Amount { get; init; }

    /// <summary>
    /// A random key provided by the client, per unique consent payment. Maximum of 128 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a consent payment fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single payment is created. If the request was successfully processed, it will prevent any payment that uses the same idempotency key, and was received within 48 hours of the first request, from being processed.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// A reference for the payment. This must be an alphanumeric string with at most 18 characters and must not contain any special characters (since not all institutions support them).
    /// If not provided, Plaid will automatically fall back to the reference from consent. In order to track settlement via Payment Confirmation, each payment must have a unique reference. If the reference provided through the API is not unique, Plaid will adjust it.
    /// Some institutions may limit the reference to less than 18 characters. If necessary, Plaid will adjust the reference by truncating it to fit the institution's requirements.
    /// Both the originally provided and automatically adjusted references (if any) can be found in the <c>reference</c> and <c>adjusted_reference</c> fields, respectively.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [StringLength(18, MinimumLength = 1)]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scope")]
    public PaymentInitiationConsentScope? Scope { get; init; }

    /// <summary>
    /// Decides the mode under which the payment processing should be performed, using <c>IMMEDIATE</c> as default.
    /// <para>
    /// <c>IMMEDIATE</c>: Will immediately execute the payment, waiting for a response from the ASPSP before returning the result of the payment initiation. This is ideal for user-present flows.
    /// </para>
    /// <para>
    ///  <c>ASYNC</c>: Will accept a payment execution request and schedule it for processing, immediately returning the new <c>payment_id</c>. Listen for webhooks to obtain real-time updates on the payment status. This is ideal for non user-present flows.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processing_mode")]
    public PaymentInitiationConsentProcessingMode? ProcessingMode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
