using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCheckReportPartnerInsightsGetResponse defines the response schema for <c>/cra/check_report/partner_insights/get</c>.
/// </summary>
public record CraCheckReportPartnerInsightsGetResponse
{
    /// <summary>
    /// The Partner Insights report of the bank data for an end user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("report")]
    public CraPartnerInsights? Report { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// If the Partner Insights generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<CraReportWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
