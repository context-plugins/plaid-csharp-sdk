using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The payer's bank account numbers. Exactly one of IBAN or Bacs data is required.
/// </summary>
public record PaymentInitiationConsentPayerNumbers
{
    /// <summary>
    /// An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public PaymentInitiationOptionalRestrictionBacs? Bacs { get; init; }

    /// <summary>
    /// International Bank Account Number (IBAN).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [StringLength(34, MinimumLength = 15)]
    public string? Iban { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
