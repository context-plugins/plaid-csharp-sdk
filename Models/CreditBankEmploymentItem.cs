using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details and metadata for an end user's Item.
/// </summary>
public record CreditBankEmploymentItem
{
    /// <summary>
    /// The unique identifier for the Item.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The time when this Item's data was last retrieved from the financial institution, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonPropertyName("last_updated_time")]
    public required DateTimeOffset LastUpdatedTime { get; init; }

    /// <summary>
    /// The unique identifier of the institution associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The name of the institution associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_name")]
    public required string InstitutionName { get; init; }

    /// <summary>
    /// The bank employment information for this Item. Each entry in the array is a different employer found.
    /// </summary>
    [JsonPropertyName("bank_employments")]
    public required IReadOnlyList<CreditBankEmployment> BankEmployments { get; init; }

    /// <summary>
    /// The Item's accounts that have Bank Employment data.
    /// </summary>
    [JsonPropertyName("bank_employment_accounts")]
    public required IReadOnlyList<CreditBankIncomeAccount> BankEmploymentAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
