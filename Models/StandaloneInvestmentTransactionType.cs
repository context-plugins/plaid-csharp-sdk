using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Valid values for investment transaction types and subtypes. Note that transactions representing inflow of cash will appear as negative amounts, outflow of cash will appear as positive amounts.
/// </summary>
public record StandaloneInvestmentTransactionType
{
    /// <summary>
    /// Buying an investment
    /// </summary>
    [JsonPropertyName("buy")]
    public required BuyType Buy { get; init; }

    /// <summary>
    /// Selling an investment
    /// </summary>
    [JsonPropertyName("sell")]
    public required SellType Sell { get; init; }

    /// <summary>
    /// A cancellation of a pending transaction
    /// </summary>
    [JsonPropertyName("cancel")]
    public required string Cancel { get; init; }

    /// <summary>
    /// Activity that modifies a cash position
    /// </summary>
    [JsonPropertyName("cash")]
    public required CashType Cash { get; init; }

    /// <summary>
    /// Fees on the account, e.g. commission, bookkeeping, options-related.
    /// </summary>
    [JsonPropertyName("fee")]
    public required FeeType Fee { get; init; }

    /// <summary>
    /// Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
    /// </summary>
    [JsonPropertyName("transfer")]
    public required StandaloneInvestmentTransactionTransferType Transfer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
