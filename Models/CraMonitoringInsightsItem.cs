using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing a Monitoring Insights Item
/// </summary>
public record CraMonitoringInsightsItem
{
    /// <summary>
    /// The date and time when the specific insights were generated (per-item), in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonPropertyName("date_generated")]
    public required DateTimeOffset DateGenerated { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with the insights
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The id of the financial institution associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The full financial institution name associated with the Item.
    /// </summary>
    [JsonPropertyName("institution_name")]
    public required string InstitutionName { get; init; }

    /// <summary>
    /// An object with details of the Monitoring Insights Item's status.
    /// </summary>
    [JsonPropertyName("status")]
    public required MonitoringInsightsItemStatus Status { get; init; }

    /// <summary>
    /// An object representing the Monitoring Insights for the given Item
    /// </summary>
    [JsonPropertyName("insights")]
    public required MonitoringInsights? Insights { get; init; }

    /// <summary>
    /// Data about each of the accounts open on the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<BaseReportAccount>? Accounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
