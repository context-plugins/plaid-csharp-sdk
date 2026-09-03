using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of objects that describe requests and responses for services.
/// </summary>
public record Services
{
    /// <summary>
    /// A collection of details related to a fulfillment service or product in terms of request, process and result.
    /// </summary>
    [JsonPropertyName("SERVICE")]
    public required Service Service { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
