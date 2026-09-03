using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details and metadata for an end user's Item within the Home Lending Income Report.
/// </summary>
public record CraVerificationIncomeItem
{
    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The Item's accounts that have bank income data.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<CraVerificationIncomeAccount> Accounts { get; init; }

    /// <summary>
    /// The time when this Item's data was last retrieved from the financial institution.
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
