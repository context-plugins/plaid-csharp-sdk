using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Depository account information for the associated user.
/// </summary>
public record BeaconUserRequestDepositoryAccount
{
    /// <summary>
    /// Must be a valid US Bank Account Number
    /// </summary>
    [JsonPropertyName("account_number")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The routing number of the account.
    /// </summary>
    [JsonPropertyName("routing_number")]
    public required string RoutingNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
