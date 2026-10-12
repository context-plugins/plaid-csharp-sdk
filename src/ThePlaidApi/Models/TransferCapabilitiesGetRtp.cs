using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains the supported service types in RTP
/// </summary>
public record TransferCapabilitiesGetRtp
{
    /// <summary>
    /// When <c>true</c>, the linked Item's institution supports RTP credit transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit")]
    public bool? Credit { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
