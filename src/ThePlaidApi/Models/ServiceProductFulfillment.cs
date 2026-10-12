using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of details related to a fulfillment service or product in terms of request, process and result.
/// </summary>
public record ServiceProductFulfillment
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("SERVICE_PRODUCT_FULFILLMENT_DETAIL")]
    public required ServiceProductFulfillmentDetail ServiceProductFulfillmentDetail { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
