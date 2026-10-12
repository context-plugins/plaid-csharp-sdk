using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of Bank Accounts linked to an Item that is associated with this Beacon User.
/// </summary>
public record BeaconBankAccounts
{
    /// <summary>
    /// The Plaid Item ID the Bank Accounts belong to.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    [JsonPropertyName("accounts")]
    public required IReadOnlyList<BeaconBankAccountInsights> Accounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
