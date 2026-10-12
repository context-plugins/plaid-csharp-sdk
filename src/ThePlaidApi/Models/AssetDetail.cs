using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about an asset.
/// </summary>
public record AssetDetail
{
    /// <summary>
    /// A vendor created unique Identifier.
    /// </summary>
    [JsonPropertyName("AssetUniqueIdentifier")]
    public required string AssetUniqueIdentifier { get; init; }

    /// <summary>
    /// A unique alphanumeric string identifying an asset.
    /// </summary>
    [JsonPropertyName("AssetAccountIdentifier")]
    public required string AssetAccountIdentifier { get; init; }

    /// <summary>
    /// Account Report As of Date / Create Date. Format YYYY-MM-DD
    /// </summary>
    [JsonPropertyName("AssetAsOfDate")]
    public required string AssetAsOfDate { get; init; }

    /// <summary>
    /// A text description that further defines the Asset. This could be used to describe the shares associated with the stocks, bonds or mutual funds, retirement funds or business owned that the borrower has disclosed (named) as an asset.
    /// </summary>
    [JsonPropertyName("AssetDescription")]
    public required string? AssetDescription { get; init; }

    /// <summary>
    /// Asset Account Available Balance.
    /// </summary>
    [JsonPropertyName("AssetAvailableBalanceAmount")]
    public required double AssetAvailableBalanceAmount { get; init; }

    /// <summary>
    /// Asset Account Current Balance.
    /// </summary>
    [JsonPropertyName("AssetCurrentBalanceAmount")]
    public required double AssetCurrentBalanceAmount { get; init; }

    /// <summary>
    /// Total market value of holdings (non-restricted, vested, not crypto, not other, not cash) Note: Any employer stock plan balance must be excluded from the total account balance (identification is 'stock plan')
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetHoldingBalanceAmount")]
    public double? AssetHoldingBalanceAmount { get; init; }

    /// <summary>
    /// HoldingsBalance net MarginAmount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetHoldingBalanceNetMarginAmount")]
    public double? AssetHoldingBalanceNetMarginAmount { get; init; }

    /// <summary>
    /// Total market value of all bonds held (non-restricted, vested)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetBondsBalanceAmount")]
    public double? AssetBondsBalanceAmount { get; init; }

    /// <summary>
    /// Total market value of all stocks held (non-restricted, vested, not employer sponsored stock plan)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetStocksBalanceAmount")]
    public double? AssetStocksBalanceAmount { get; init; }

    /// <summary>
    /// Total balance of all cryptocurrency held (non-restricted, vested)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetCryptoBalanceAmount")]
    public double? AssetCryptoBalanceAmount { get; init; }

    /// <summary>
    /// Total balance of all other holding types (non-restricted, vested)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetOtherBalanceAmount")]
    public double? AssetOtherBalanceAmount { get; init; }

    /// <summary>
    /// loan balance (amount owed by account owner)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetMarginAmountBalance")]
    public double? AssetMarginAmountBalance { get; init; }

    /// <summary>
    /// amount available for cash withdrawal
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetAvailableCashBalanceAmount")]
    public double? AssetAvailableCashBalanceAmount { get; init; }

    /// <summary>
    /// cash balance of the account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetCashBalanceAmount")]
    public double? AssetCashBalanceAmount { get; init; }

    /// <summary>
    /// A value from a MISMO prescribed list that specifies financial assets in a mortgage loan transaction. Assets may be either liquid or fixed and are associated with a corresponding asset amount.
    /// </summary>
    [JsonPropertyName("AssetType")]
    public required AssetType AssetType { get; init; }

    /// <summary>
    /// Additional Asset Description. Some examples are Investment Tax-Deferred, Loan, 401K, 403B, Checking, Money Market, Credit Card, ROTH, 529, Biller, ROLLOVER, CD, Savings, Investment Taxable, IRA, Mortgage, Line Of Credit.
    /// </summary>
    [JsonPropertyName("AssetTypeAdditionalDescription")]
    public required string? AssetTypeAdditionalDescription { get; init; }

    /// <summary>
    /// The number of days requested from the Financial Institution. Example: When looking for 3 months of data from the FI, pass in 90 days.
    /// </summary>
    [JsonPropertyName("AssetDaysRequestedCount")]
    public required int AssetDaysRequestedCount { get; init; }

    /// <summary>
    /// Ownership type of the asset account.
    /// </summary>
    [JsonPropertyName("AssetOwnershipType")]
    public required string? AssetOwnershipType { get; init; }

    /// <summary>
    /// Whether or not the account is a retirement account (e.g., 401K, 403b, 457, thrift savings plans, traditional and Roth, IRAs, SEP-IRA, SIMPLE-IRA, KEOGH, state retirement savings plans, other independent and IRS-qualified employer retirement plans)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetRetirementIndicator")]
    public AssetRetirementIndicator? AssetRetirementIndicator { get; init; }

    /// <summary>
    /// Whether the account is employer sponsored retirement account or not (e.g., 401K, 403b, 457, thrift savings plan)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetEmployerSponsoredIndicator")]
    public AssetEmployerSponsoredIndicator? AssetEmployerSponsoredIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
