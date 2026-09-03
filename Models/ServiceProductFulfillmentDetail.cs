using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record ServiceProductFulfillmentDetail
{
    /// <summary>
    /// A string that uniquely identifies a type of order Verification of Asset.
    /// </summary>
    [JsonPropertyName("VendorOrderIdentifier")]
    public required string? VendorOrderIdentifier { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ServiceProductFulfillmentIdentifier")]
    public required ServiceProductFulfillmentIdentifier ServiceProductFulfillmentIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
