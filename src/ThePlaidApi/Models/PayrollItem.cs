using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing information about the payroll item.
/// </summary>
public record PayrollItem
{
    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

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

    [JsonPropertyName("accounts")]
    public required IReadOnlyList<PayrollIncomeAccountData?> Accounts { get; init; }

    [JsonPropertyName("payroll_income")]
    public required IReadOnlyList<PayrollIncomeObject> PayrollIncome { get; init; }

    /// <summary>
    /// Details about the status of the payroll item.
    /// </summary>
    [JsonPropertyName("status")]
    public required PayrollItemStatus? Status { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the Item was updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset? UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
