using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Depository account information for the associated user.
/// </summary>
public record BeaconUserDepositoryAccount
{
    /// <summary>
    /// The last 2-4 numeric characters of this account's account number.
    /// </summary>
    [JsonPropertyName("account_mask")]
    public required string AccountMask { get; init; }

    /// <summary>
    /// The routing number of the account.
    /// </summary>
    [JsonPropertyName("routing_number")]
    public required string RoutingNumber { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("added_at")]
    public required DateTimeOffset AddedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
