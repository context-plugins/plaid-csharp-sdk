using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCheckReportBaseReportGetResponse defines the response schema for <c>/cra/check_report/base_report/get</c>
/// </summary>
public record CraCheckReportBaseReportGetResponse
{
    /// <summary>
    /// An object representing a Base Report
    /// </summary>
    [JsonPropertyName("report")]
    public required BaseReport Report { get; init; }

    /// <summary>
    /// This array contains any information about errors or alerts related to the Base Report that did not block generation of the report.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<BaseReportWarning> Warnings { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
