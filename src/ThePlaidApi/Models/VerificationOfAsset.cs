using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record VerificationOfAsset
{
    /// <summary>
    /// Information about a report identifier and a report name.
    /// </summary>
    [JsonPropertyName("REPORTING_INFORMATION")]
    public required ReportingInformation ReportingInformation { get; init; }

    /// <summary>
    /// A collection of details related to a fulfillment service or product in terms of request, process and result.
    /// </summary>
    [JsonPropertyName("SERVICE_PRODUCT_FULFILLMENT")]
    public required ServiceProductFulfillment ServiceProductFulfillment { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("VERIFICATION_OF_ASSET_RESPONSE")]
    public required VerificationOfAssetResponse VerificationOfAssetResponse { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
