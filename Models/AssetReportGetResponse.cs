using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AssetReportGetResponse defines the response schema for <c>/asset_report/get</c>
/// </summary>
public record AssetReportGetResponse
{
    /// <summary>
    /// An object representing an Asset Report
    /// </summary>
    [JsonPropertyName("report")]
    public required AssetReport Report { get; init; }

    /// <summary>
    /// If the Asset Report generation was successful but identity information cannot be returned, this array will contain information about the errors causing identity information to be missing
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<Warning> Warnings { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
