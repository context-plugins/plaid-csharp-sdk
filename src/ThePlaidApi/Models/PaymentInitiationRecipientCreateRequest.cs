using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationRecipientCreateRequest defines the request schema for <c>/payment_initiation/recipient/create</c>
/// </summary>
public record PaymentInitiationRecipientCreateRequest
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
    /// The name of the recipient. We recommend using strings of length 18 or less and avoid special characters to ensure compatibility with all institutions.
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the recipient. If Bacs data is not provided, an IBAN is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [StringLength(34, MinimumLength = 15)]
    public string? Iban { get; init; }

    /// <summary>
    /// An object containing a Bacs account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, Bacs data is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public RecipientBacsNullable? Bacs { get; init; }

    /// <summary>
    /// The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public PaymentInitiationAddress? Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
