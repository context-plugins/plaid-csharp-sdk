using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata related to the acceptance of Terms of Service
/// </summary>
public record TosAcceptanceMetadata
{
    /// <summary>
    /// Indicates whether the TOS agreement was accepted
    /// </summary>
    [JsonPropertyName("agreement_accepted")]
    public required bool AgreementAccepted { get; init; }

    /// <summary>
    /// The IP address of the originator when they accepted the TOS. Formatted as an IPv4 or IPv6 IP address
    /// </summary>
    [JsonPropertyName("originator_ip_address")]
    public required string OriginatorIpAddress { get; init; }

    /// <summary>
    /// ISO8601 timestamp indicating when the originator accepted the TOS
    /// </summary>
    [JsonPropertyName("agreement_accepted_at")]
    public required DateTimeOffset AgreementAcceptedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
