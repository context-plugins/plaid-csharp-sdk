using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record AssetHolding
{
    /// <summary>
    /// Unique id of investment position
    /// </summary>
    [JsonPropertyName("AssetHoldingID")]
    public required string? AssetHoldingId { get; init; }

    /// <summary>
    /// US Dollar
    /// </summary>
    [JsonPropertyName("Currency")]
    public required string? Currency { get; init; }

    /// <summary>
    /// Description of holding
    /// </summary>
    [JsonPropertyName("AssetHoldingDescription")]
    public required string? AssetHoldingDescription { get; init; }

    /// <summary>
    /// Investment position's market ticker symbol
    /// </summary>
    [JsonPropertyName("AssetHoldingSymbol")]
    public required string? AssetHoldingSymbol { get; init; }

    /// <summary>
    /// Security name of investment holding
    /// </summary>
    [JsonPropertyName("AssetHoldingSecurityName")]
    public required string? AssetHoldingSecurityName { get; init; }

    /// <summary>
    /// Number of units of holding
    /// </summary>
    [JsonPropertyName("AssetHoldingUnits")]
    public required double? AssetHoldingUnits { get; init; }

    /// <summary>
    /// market value of investment position
    /// </summary>
    [JsonPropertyName("AssetHoldingMarketValueAmount")]
    public required double? AssetHoldingMarketValueAmount { get; init; }

    /// <summary>
    /// current price of investment holding
    /// </summary>
    [JsonPropertyName("AssetHoldingCurrentPriceAmount")]
    public required double? AssetHoldingCurrentPriceAmount { get; init; }

    /// <summary>
    /// Type of holding (e.g. bond, stock, crypto, other)
    /// </summary>
    [JsonPropertyName("AssetHoldingType")]
    public required AssetHoldingType? AssetHoldingType { get; init; }

    /// <summary>
    /// Whether or not the stock is restricted, i.e. "Restricted" or "Not Restricted"
    /// </summary>
    [JsonPropertyName("AssetHoldingRestrictedIndicator")]
    public required AssetHoldingRestrictedIndicator? AssetHoldingRestrictedIndicator { get; init; }

    /// <summary>
    /// Amount of holding vested
    /// </summary>
    [JsonPropertyName("AssetHoldingVestedAmount")]
    public required double? AssetHoldingVestedAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
