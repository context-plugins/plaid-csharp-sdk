using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A single acquisition lot within a holding.
/// </summary>
public record HoldingTaxLot
{
    /// <summary>
    /// The financial institution's identifier for this lot. Null if the institution does not provide a lot identifier.
    /// </summary>
    [JsonPropertyName("institution_lot_id")]
    public required string? InstitutionLotId { get; init; }

    /// <summary>
    /// The date and time this lot was acquired, in ISO 8601 format. Null if the institution does not provide acquisition datetime data.
    /// </summary>
    [JsonPropertyName("original_purchase_datetime")]
    public required DateTimeOffset? OriginalPurchaseDatetime { get; init; }

    /// <summary>
    /// The number of units of the security in this lot.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double? Quantity { get; init; }

    /// <summary>
    /// The price per unit of the security at the time this lot was acquired.
    /// </summary>
    [JsonPropertyName("purchase_price")]
    public required double? PurchasePrice { get; init; }

    /// <summary>
    /// The total cost basis of this lot, inclusive of any fees.
    /// </summary>
    [JsonPropertyName("cost_basis")]
    public required double? CostBasis { get; init; }

    /// <summary>
    /// The current market value of this lot.
    /// </summary>
    [JsonPropertyName("current_value")]
    public required double? CurrentValue { get; init; }

    /// <summary>
    /// Indicates whether a holding lot position is long or short. Possible values are <c>LONG</c> and <c>SHORT</c>.
    /// </summary>
    [JsonPropertyName("position_type")]
    public required HoldingTaxLotPositionType? PositionType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
