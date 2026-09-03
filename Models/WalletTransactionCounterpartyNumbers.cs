using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The counterparty's bank account numbers. Exactly one of IBAN or Bacs data is required.
/// </summary>
public record WalletTransactionCounterpartyNumbers
{
    /// <summary>
    /// The account number and sort code of the counterparty's account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public WalletTransactionCounterpartyBacs? Bacs { get; init; }

    /// <summary>
    /// International Bank Account Number for a Wallet Transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international")]
    public WalletTransactionCounterpartyInternational? International { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
