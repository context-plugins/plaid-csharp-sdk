using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// CraReportGetRequestProduct specifies a product and version for a <c>/cra/report/get</c> call.
/// </summary>
public record CraReportGetRequestProduct
{
    [JsonPropertyName("product")]
    public required Products Product { get; init; }

    /// <summary>
    /// The version of the product that was generated.
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
