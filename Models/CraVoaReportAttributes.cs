using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Attributes for the VOA report.
/// </summary>
public record CraVoaReportAttributes
{
    /// <summary>
    /// Total amount of debit transactions into the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonPropertyName("total_inflow_amount")]
    public required TotalReportInflowAmount? TotalInflowAmount { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonPropertyName("total_outflow_amount")]
    public required TotalReportOutflowAmount? TotalOutflowAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
