using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCheckReportCashflowInsightsGetResponse defines the response schema for <c>/cra/check_report/cashflow_insights/get</c>.
/// </summary>
public record CraCheckReportCashflowInsightsGetResponse
{
    /// <summary>
    /// Contains data for the CRA Cashflow Insights Report.
    /// </summary>
    [JsonPropertyName("report")]
    public required CraCashflowInsightsReport Report { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// If the Cashflow Insights generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<CraReportWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
