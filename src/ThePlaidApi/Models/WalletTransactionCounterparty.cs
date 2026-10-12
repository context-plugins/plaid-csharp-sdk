using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the e-wallet transaction's counterparty
/// </summary>
public record WalletTransactionCounterparty
{
    /// <summary>
    /// The name of the counterparty
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// The counterparty's bank account numbers. Exactly one of IBAN or Bacs data is required.
    /// </summary>
    [JsonPropertyName("numbers")]
    public required WalletTransactionCounterpartyNumbers Numbers { get; init; }

    /// <summary>
    /// The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public PaymentInitiationAddress? Address { get; init; }

    /// <summary>
    /// The counterparty's birthdate, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
