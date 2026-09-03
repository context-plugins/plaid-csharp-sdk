using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCheckReportFreddieMacGetResponse defines the response schema for <c>/cra/check_report/freddie_mac/get</c>
/// </summary>
public record CraCheckReportFreddieMacGetResponse
{
    /// <summary>
    /// An object representing a Base Report with Freddie Mac schema.
    /// </summary>
    [JsonPropertyName("DEAL")]
    public required CraCheckReportFreddieMacVerificationOfAssetsDeal Deal { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The Verification Of Assets (VOA) schema version.
    /// </summary>
    [JsonPropertyName("SchemaVersion")]
    public required double SchemaVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
