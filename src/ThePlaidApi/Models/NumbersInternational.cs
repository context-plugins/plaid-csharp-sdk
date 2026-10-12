using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Identifying information for transferring money to or from an international bank account via wire transfer.
/// </summary>
public record NumbersInternational
{
    /// <summary>
    /// The Plaid account ID associated with the account numbers
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the account
    /// </summary>
    [JsonPropertyName("iban")]
    public required string Iban { get; init; }

    /// <summary>
    /// The Business Identifier Code (BIC) for the account
    /// </summary>
    [JsonPropertyName("bic")]
    public required string Bic { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
