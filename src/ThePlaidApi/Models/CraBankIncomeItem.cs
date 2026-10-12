using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details and metadata for an end user's Item.
/// </summary>
public record CraBankIncomeItem
{
    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    /// <summary>
    /// The Item's accounts that have bank income data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<CraBankIncomeAccount>? Accounts { get; init; }

    /// <summary>
    /// This is a V1 (II1) field. For the V2 (II2) equivalent, use the <c>accounts</c> field. The Item's accounts that have bank income data.
    /// </summary>
    [JsonPropertyName("bank_income_accounts")]
    public required IReadOnlyList<CraBankIncomeAccount> BankIncomeAccounts { get; init; }

    /// <summary>
    /// This is a V1 (II1) field. For the V2 (II2) equivalent, use the report-level <c>income_streams</c> field. The income sources for this Item. Each entry in the array is a single income source.
    /// </summary>
    [JsonPropertyName("bank_income_sources")]
    public required IReadOnlyList<CraBankIncomeSource> BankIncomeSources { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
