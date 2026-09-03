using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Identifying information for transferring money to or from a Canadian bank account via EFT.
/// </summary>
public record NumbersEft
{
    /// <summary>
    /// The Plaid account ID associated with the account numbers
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The EFT account number for the account
    /// </summary>
    [JsonPropertyName("account")]
    public required string Account { get; init; }

    /// <summary>
    /// The EFT institution number for the account
    /// </summary>
    [JsonPropertyName("institution")]
    public required string Institution { get; init; }

    /// <summary>
    /// The EFT branch number for the account
    /// </summary>
    [JsonPropertyName("branch")]
    public required string Branch { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
