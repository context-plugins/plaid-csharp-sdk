using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of an Item within a VOA report.
/// </summary>
public record CraVoaReportItem
{
    /// <summary>
    /// Data about each of the accounts open on the Item.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<CraVoaReportAccount> Accounts { get; init; }

    /// <summary>
    /// The full financial institution name associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_name")]
    public required string InstitutionName { get; init; }

    /// <summary>
    /// The id of the financial institution associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The date and time when this Item's data was last retrieved from the financial institution, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("last_update_time")]
    public required DateTimeOffset LastUpdateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
