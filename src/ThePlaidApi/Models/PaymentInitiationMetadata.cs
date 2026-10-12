using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.
/// </summary>
public record PaymentInitiationMetadata
{
    /// <summary>
    /// Indicates whether the institution supports payments from a different country.
    /// </summary>
    [JsonPropertyName("supports_international_payments")]
    public required bool SupportsInternationalPayments { get; init; }

    /// <summary>
    /// Indicates whether the institution supports SEPA Instant payments.
    /// </summary>
    [JsonPropertyName("supports_sepa_instant")]
    public required bool SupportsSepaInstant { get; init; }

    /// <summary>
    /// A mapping of currency to maximum payment amount (denominated in the smallest unit of currency) supported by the institution.
    /// <para>
    /// Example: <c>{"GBP": "10000"}</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("maximum_payment_amount")]
    public required IReadOnlyDictionary<string, string> MaximumPaymentAmount { get; init; }

    /// <summary>
    /// Indicates whether the institution supports returning refund details when initiating a payment.
    /// </summary>
    [JsonPropertyName("supports_refund_details")]
    public required bool SupportsRefundDetails { get; init; }

    /// <summary>
    /// Metadata specifically related to valid Payment Initiation standing order configurations for the institution.
    /// </summary>
    [JsonPropertyName("standing_order_metadata")]
    public required PaymentInitiationStandingOrderMetadata? StandingOrderMetadata { get; init; }

    /// <summary>
    /// Indicates whether the institution supports payment consents.
    /// </summary>
    [JsonPropertyName("supports_payment_consents")]
    public required bool SupportsPaymentConsents { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
