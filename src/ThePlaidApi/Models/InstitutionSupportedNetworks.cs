using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains the RTP and RfP network and types supported by the linked Item's institution.
/// </summary>
public record InstitutionSupportedNetworks
{
    /// <summary>
    /// Contains the supported service types in RTP
    /// </summary>
    [JsonPropertyName("rtp")]
    public required TransferCapabilitiesGetRtp Rtp { get; init; }

    /// <summary>
    /// Contains the supported service types in RfP
    /// </summary>
    [JsonPropertyName("rfp")]
    public required TransferCapabilitiesGetRfP Rfp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
