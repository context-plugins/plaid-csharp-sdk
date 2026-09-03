using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record AssetTransactionDetail
{
    /// <summary>
    /// A vendor created unique Identifier.
    /// </summary>
    [JsonPropertyName("AssetTransactionUniqueIdentifier")]
    public required string AssetTransactionUniqueIdentifier { get; init; }

    /// <summary>
    /// Asset Transaction Amount.
    /// </summary>
    [JsonPropertyName("AssetTransactionAmount")]
    public required double AssetTransactionAmount { get; init; }

    /// <summary>
    /// Asset Transaction Date.
    /// </summary>
    [JsonPropertyName("AssetTransactionDate")]
    public required DateTimeOffset AssetTransactionDate { get; init; }

    /// <summary>
    /// Asset Transaction Post Date.
    /// </summary>
    [JsonPropertyName("AssetTransactionPostDate")]
    public required DateTimeOffset AssetTransactionPostDate { get; init; }

    /// <summary>
    /// Asset Transaction Type.
    /// </summary>
    [JsonPropertyName("AssetTransactionType")]
    public required AssetTransactionType AssetTransactionType { get; init; }

    /// <summary>
    /// Asset Investment Transaction Type Enumerated derived by Vendor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetInvestmentTransactionType")]
    public AssetInvestmentTransactionType? AssetInvestmentTransactionType { get; init; }

    /// <summary>
    /// Populate with who did the transaction.
    /// </summary>
    [JsonPropertyName("AssetTransactionPaidByName")]
    public required string? AssetTransactionPaidByName { get; init; }

    /// <summary>
    /// Populate with for whom the transaction is done
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AssetTransactionPaidToName")]
    public string? AssetTransactionPaidToName { get; init; }

    /// <summary>
    /// FI Provided - examples are atm, cash, check, credit, debit, deposit, directDebit, directDeposit, dividend, fee, interest, other, payment, pointOfSale, repeatPayment, serviceCharge, transfer.
    /// </summary>
    [JsonPropertyName("AssetTransactionTypeAdditionalDescription")]
    public required string? AssetTransactionTypeAdditionalDescription { get; init; }

    /// <summary>
    /// Asset Investment Transaction Type Description.
    /// </summary>
    [JsonPropertyName("AssetInvestmentTransactionTypeDescription")]
    public required string? AssetInvestmentTransactionTypeDescription { get; init; }

    /// <summary>
    /// Asset Transaction Category Type Enumerated derived by Vendor.
    /// </summary>
    [JsonPropertyName("AssetTransactionCategoryType")]
    public required AssetTransactionCategoryType? AssetTransactionCategoryType { get; init; }

    /// <summary>
    /// FI provided Transaction Identifier.
    /// </summary>
    [JsonPropertyName("FinancialInstitutionTransactionIdentifier")]
    public required string? FinancialInstitutionTransactionIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
