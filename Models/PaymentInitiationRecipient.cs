using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationRecipient defines a payment initiation recipient
/// </summary>
public record PaymentInitiationRecipient
{
    /// <summary>
    /// The ID of the recipient.
    /// </summary>
    [JsonPropertyName("recipient_id")]
    public required string RecipientId { get; init; }

    /// <summary>
    /// The name of the recipient.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public PaymentInitiationAddress? Address { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public string? Iban { get; init; }

    /// <summary>
    /// An object containing a Bacs account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, Bacs data is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public RecipientBacsNullable? Bacs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
