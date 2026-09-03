using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationConsentCreateRequest defines the request schema for <c>/payment_initiation/consent/create</c>
/// </summary>
public record PaymentInitiationConsentCreateRequest
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
    /// The ID of the recipient the payment consent is for. The created consent can be used to transfer funds to this recipient only.
    /// </summary>
    [JsonPropertyName("recipient_id")]
    public required string RecipientId { get; init; }

    /// <summary>
    /// A reference for the payment consent. This must be an alphanumeric string with at most 18 characters and must not contain any special characters.
    /// </summary>
    [JsonPropertyName("reference")]
    [StringLength(18, MinimumLength = 1)]
    public required string Reference { get; init; }

    /// <summary>
    /// An array of payment consent scopes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    [MinLength(1)]
    [UniqueItems]
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
    /// Limitations that will be applied to payments initiated using the payment consent.
    /// </summary>
    [JsonPropertyName("constraints")]
    public required PaymentInitiationConsentConstraints Constraints { get; init; }

    /// <summary>
    /// (Deprecated) Additional payment consent options. Please use <c>payer_details</c> to specify the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public ExternalPaymentInitiationConsentOptions? Options { get; init; }

    /// <summary>
    /// An object representing the payment consent payer details.
    /// Payer <c>name</c> and account <c>numbers</c> are required to lock the account to which the consent can be created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_details")]
    public PaymentInitiationConsentPayerDetails? PayerDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
