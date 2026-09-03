using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional payment options
/// </summary>
public record PaymentOptions
{
    /// <summary>
    /// When <c>true</c>, Plaid will attempt to request refund details from the payee's financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the <c>/payment_initiation/payment/get</c> response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_refund_details")]
    public bool? RequestRefundDetails { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the payer's account. Where possible, the end user will be able to send payments only from the specified bank account if provided.
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

    /// <summary>
    /// Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). In responses, if the scheme is not explicitly specified in the request, this value will be <c>null</c>. Using unsupported values will result in a failed payment.
    /// <para>
    /// <c>LOCAL_DEFAULT</c>: The default payment scheme for the selected market and currency will be used.
    /// </para>
    /// <para>
    /// <c>LOCAL_INSTANT</c>: The instant payment scheme for the selected market and currency will be used (if applicable). Fees may be applied by the institution.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER</c>: The standard payment to a beneficiary within the SEPA area.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER_INSTANT</c>: Instant payment within the SEPA area. May involve additional fees and may not be available at some banks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheme")]
    public PaymentScheme? Scheme { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
