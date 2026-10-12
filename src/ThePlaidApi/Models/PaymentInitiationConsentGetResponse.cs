using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationConsentGetResponse defines the response schema for <c>/payment_initiation/consent/get</c>
/// </summary>
public record PaymentInitiationConsentGetResponse
{
    /// <summary>
    /// The consent ID.
    /// </summary>
    [JsonPropertyName("consent_id")]
    [MinLength(1)]
    public required string ConsentId { get; init; }

    /// <summary>
    /// The status of the payment consent.
    /// <para>
    /// <c>UNAUTHORISED</c>: Consent created, but requires user authorisation.
    /// </para>
    /// <para>
    /// <c>REJECTED</c>: Consent authorisation was rejected by the bank.
    /// </para>
    /// <para>
    /// <c>AUTHORISED</c>: Consent is active and ready to be used.
    /// </para>
    /// <para>
    /// <c>REVOKED</c>: Consent has been revoked and can no longer be used.
    /// </para>
    /// <para>
    /// <c>EXPIRED</c>: Consent is no longer valid.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required PaymentInitiationConsentStatus Status { get; init; }

    /// <summary>
    /// Consent creation timestamp, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The ID of the recipient the payment consent is for.
    /// </summary>
    [JsonPropertyName("recipient_id")]
    [MinLength(1)]
    public required string RecipientId { get; init; }

    /// <summary>
    /// A reference for the payment consent.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// Limitations that will be applied to payments initiated using the payment consent.
    /// </summary>
    [JsonPropertyName("constraints")]
    public required PaymentInitiationConsentConstraints Constraints { get; init; }

    /// <summary>
    /// Deprecated, use the 'type' field instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public IReadOnlyList<PaymentInitiationConsentScope>? Scopes { get; init; }

    /// <summary>
    /// Payment consent type. Defines possible use case for payments made with the given consent.
    /// <para>
    /// <c>SWEEPING</c>: Allows moving money between accounts owned by the same user.
    /// </para>
    /// <para>
    /// <c>COMMERCIAL</c>: Allows initiating payments from the user's account to third parties.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public PaymentInitiationConsentType? Type { get; init; }

    /// <summary>
    /// Details about external payment refund
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_details")]
    public ExternalPaymentRefundDetails? PayerDetails { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
