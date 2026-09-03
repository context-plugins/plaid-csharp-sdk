using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/capabilities/get</c>
/// </summary>
public record TransferCapabilitiesGetResponse
{
    /// <summary>
    /// Contains the RTP and RfP network and types supported by the linked Item's institution.
    /// </summary>
    [JsonPropertyName("institution_supported_networks")]
    public required InstitutionSupportedNetworks InstitutionSupportedNetworks { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
