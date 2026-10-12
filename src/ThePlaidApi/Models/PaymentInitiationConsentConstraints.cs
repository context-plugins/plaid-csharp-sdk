using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Limitations that will be applied to payments initiated using the payment consent.
/// </summary>
public record PaymentInitiationConsentConstraints
{
    /// <summary>
    /// Life span for the payment consent. After the <c>to</c> date the payment consent expires and can no longer be used for payment initiation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valid_date_time")]
    public PaymentConsentValidDateTime? ValidDateTime { get; init; }

    /// <summary>
    /// Maximum amount of a single payment initiated using the payment consent.
    /// </summary>
    [JsonPropertyName("max_payment_amount")]
    public required PaymentAmount MaxPaymentAmount { get; init; }

    /// <summary>
    /// A list of amount limitations per period of time.
    /// </summary>
    [JsonPropertyName("periodic_amounts")]
    [MinLength(1)]
    public required IReadOnlyList<PaymentConsentPeriodicAmount> PeriodicAmounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
