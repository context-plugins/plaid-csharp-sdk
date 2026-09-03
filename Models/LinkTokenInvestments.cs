using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Configuration parameters for the Investments product
/// </summary>
public record LinkTokenInvestments
{
    /// <summary>
    /// If <c>true</c>, allow self-custody crypto wallets to be added without requiring signature verification. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_unverified_crypto_wallets")]
    public bool? AllowUnverifiedCryptoWallets { get; init; }

    /// <summary>
    /// If <c>true</c>, allow users to manually enter Investments account and holdings information. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_manual_entry")]
    public bool? AllowManualEntry { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
