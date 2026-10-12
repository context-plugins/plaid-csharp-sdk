using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of a payment consent has changed.
/// </summary>
public record PaymentInitiationConsentStatusUpdateWebhook
{
    /// <summary>
    /// <c>PAYMENT_INITIATION</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>CONSENT_STATUS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>id</c> for the consent being updated
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
    [JsonPropertyName("old_status")]
    public required PaymentInitiationConsentStatus OldStatus { get; init; }

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
    [JsonPropertyName("new_status")]
    public required PaymentInitiationConsentStatus NewStatus { get; init; }

    /// <summary>
    /// The timestamp of the update, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
