using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about external payment refund
/// </summary>
public record ExternalPaymentRefundDetails
{
    /// <summary>
    /// The name of the account holder.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the account.
    /// </summary>
    [JsonPropertyName("iban")]
    public required string? Iban { get; init; }

    /// <summary>
    /// An object containing a Bacs account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, Bacs data is required.
    /// </summary>
    [JsonPropertyName("bacs")]
    public required RecipientBacsNullable? Bacs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
