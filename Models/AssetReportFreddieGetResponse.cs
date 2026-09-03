using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AssetReportFreddieGetResponse defines the response schema for <c>/credit/asset_report/freddie_mac/get</c>
/// </summary>
public record AssetReportFreddieGetResponse
{
    /// <summary>
    /// An object representing an Asset Report with Freddie Mac schema.
    /// </summary>
    [JsonPropertyName("DEAL")]
    public required AssetReportFreddie Deal { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The Verification Of Assets (aka VOA or Freddie Mac Schema) schema version.
    /// </summary>
    [JsonPropertyName("SchemaVersion")]
    public required double SchemaVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
