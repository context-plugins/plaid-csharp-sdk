using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCheckReportNetworkInsightsGetResponse defines the response schema for <c>/cra/check_report/network_insights/get</c>.
/// </summary>
public record CraCheckReportNetworkInsightsGetResponse
{
    /// <summary>
    /// Contains data for the CRA Network Attributes Report.
    /// </summary>
    [JsonPropertyName("report")]
    public required CraNetworkInsightsReport Report { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// If the Network Insights generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<CraReportWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
