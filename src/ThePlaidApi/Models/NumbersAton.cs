using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Identifying information for transferring holdings to an investment account via ATON.
/// </summary>
public record NumbersAton
{
    /// <summary>
    /// The Plaid account ID associated with the account numbers
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The full account number for the account
    /// </summary>
    [JsonPropertyName("account")]
    public required string Account { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
