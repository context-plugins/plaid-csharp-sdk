using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Pay By Bank flow. This is an optional field to configure the user experience, and currently requires the amount field to be set.
/// </summary>
public record LinkTokenCreateRequestPaymentConfiguration
{
    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The description of the transfer that provides the payment context. The max length is 256.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
