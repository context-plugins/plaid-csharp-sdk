using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentCreateRequest defines the request schema for <c>/payment_initiation/payment/create</c>
/// </summary>
public record PaymentInitiationPaymentCreateRequest
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
    /// The ID of the recipient the payment is for.
    /// </summary>
    [JsonPropertyName("recipient_id")]
    public required string RecipientId { get; init; }

    /// <summary>
    /// A reference for the payment. This must be an alphanumeric string with at most 18 characters and must not contain any special characters (since not all institutions support them).
    /// In order to track settlement via Payment Confirmation, each payment must have a unique reference. If the reference provided through the API is not unique, Plaid will adjust it.
    /// Some institutions may limit the reference to less than 18 characters. If necessary, Plaid will adjust the reference by truncating it to fit the institution's requirements.
    /// Both the originally provided and automatically adjusted references (if any) can be found in the <c>reference</c> and <c>adjusted_reference</c> fields, respectively.
    /// </summary>
    [JsonPropertyName("reference")]
    [StringLength(18, MinimumLength = 1)]
    public required string Reference { get; init; }

    /// <summary>
    /// The amount and currency of a payment
    /// </summary>
    [JsonPropertyName("amount")]
    public required PaymentAmount Amount { get; init; }

    /// <summary>
    /// The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public ExternalPaymentScheduleRequest? Schedule { get; init; }

    /// <summary>
    /// Additional payment options
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public PaymentOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
