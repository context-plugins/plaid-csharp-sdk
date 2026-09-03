using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details and metadata for an end user's Item.
/// </summary>
public record CreditBankIncomeItem
{
    /// <summary>
    /// The Item's accounts that have Bank Income data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income_accounts")]
    public IReadOnlyList<CreditBankIncomeAccount>? BankIncomeAccounts { get; init; }

    /// <summary>
    /// The income sources for this Item. Each entry in the array is a single income source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income_sources")]
    public IReadOnlyList<CreditBankIncomeSource>? BankIncomeSources { get; init; }

    /// <summary>
    /// The time when this Item's data was last retrieved from the financial institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_updated_time")]
    public DateTimeOffset? LastUpdatedTime { get; init; }

    /// <summary>
    /// The unique identifier of the institution associated with the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// The name of the institution associated with the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_name")]
    public string? InstitutionName { get; init; }

    /// <summary>
    /// The unique identifier for the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
