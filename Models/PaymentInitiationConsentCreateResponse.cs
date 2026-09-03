using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationConsentCreateResponse defines the response schema for <c>/payment_initiation/consent/create</c>
/// </summary>
public record PaymentInitiationConsentCreateResponse
{
    /// <summary>
    /// A unique ID identifying the payment consent.
    /// </summary>
    [JsonPropertyName("consent_id")]
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
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
