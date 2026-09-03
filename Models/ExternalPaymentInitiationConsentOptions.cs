using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// (Deprecated) Additional payment consent options. Please use <c>payer_details</c> to specify the account.
/// </summary>
public record ExternalPaymentInitiationConsentOptions
{
    /// <summary>
    /// When <c>true</c>, Plaid will attempt to request refund details from the payee's financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the <c>/payment_initiation/payment/get</c> response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_refund_details")]
    public bool? RequestRefundDetails { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the payer's account. Where possible, the end user will be able to set up payment consent using only the specified bank account if provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [StringLength(34, MinimumLength = 15)]
    public string? Iban { get; init; }

    /// <summary>
    /// An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public PaymentInitiationOptionalRestrictionBacs? Bacs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
