using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The amount and currency of a payment
/// </summary>
public record PaymentAmountRefunded
{
    /// <summary>
    /// The ISO-4217 currency code of the payment. For standing orders and payment consents, <c>"GBP"</c> must be used. For Poland, Denmark, Sweden and Norway, only the local currency is currently supported.
    /// </summary>
    [JsonPropertyName("currency")]
    public required PaymentAmountCurrency Currency { get; init; }

    /// <summary>
    /// The amount of the payment. Must contain at most two digits of precision e.g. <c>1.23</c>.
    /// </summary>
    [JsonPropertyName("value")]
    [Minimum(0.01)]
    public required double Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
