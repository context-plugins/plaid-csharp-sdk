using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Payment Initiation (Europe) product. This field is required if <c>payment_initiation</c> is included in the <c>products</c> array. Either <c>payment_id</c> or <c>consent_id</c> must be provided.
/// </summary>
public record LinkTokenCreateRequestPaymentInitiation
{
    /// <summary>
    /// The <c>payment_id</c> provided by the <c>/payment_initiation/payment/create</c> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// The <c>consent_id</c> provided by the <c>/payment_initiation/consent/create</c> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consent_id")]
    public string? ConsentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
