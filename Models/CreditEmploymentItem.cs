using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The object containing employment items.
/// </summary>
public record CreditEmploymentItem
{
    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    [JsonPropertyName("employments")]
    public required IReadOnlyList<CreditEmploymentVerification> Employments { get; init; }

    /// <summary>
    /// Token to represent the underlying Employment data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employment_report_token")]
    public string? EmploymentReportToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
