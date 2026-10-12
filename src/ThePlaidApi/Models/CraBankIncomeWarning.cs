using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The warning associated with the data that was unavailable.
/// </summary>
public record CraBankIncomeWarning
{
    /// <summary>
    /// The warning type which will always be <c>BANK_INCOME_WARNING</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warning_type")]
    public CreditBankIncomeWarningType? WarningType { get; init; }

    /// <summary>
    /// The warning code identifies a specific kind of warning.
    /// <c>IDENTITY_UNAVAILABLE</c>: Unable to extract identity for the Item
    /// <c>TRANSACTIONS_UNAVAILABLE</c>: Unable to extract transactions for the Item
    /// <c>REPORT_DELETED</c>: Report deleted due to customer or consumer request
    /// <c>DATA_UNAVAILABLE</c>: No relevant data was found for the Item
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warning_code")]
    public CraBankIncomeWarningCode? WarningCode { get; init; }

    /// <summary>
    /// An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cause")]
    public CraBankIncomeCause? Cause { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
