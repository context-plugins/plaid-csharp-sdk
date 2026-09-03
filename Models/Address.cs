using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A physical mailing address.
/// </summary>
public record Address
{
    /// <summary>
    /// Data about the components comprising an address.
    /// </summary>
    [JsonPropertyName("data")]
    public required AddressData Data { get; init; }

    /// <summary>
    /// When <c>true</c>, identifies the address as the primary address on an account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary")]
    public bool? Primary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
