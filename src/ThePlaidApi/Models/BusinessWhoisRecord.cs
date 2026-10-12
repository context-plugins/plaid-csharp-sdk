using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// WHOIS metadata for the business website domain.
/// </summary>
public record BusinessWhoisRecord
{
    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("domain_created_at")]
    public required DateTimeOffset? DomainCreatedAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("domain_updated_at")]
    public required DateTimeOffset? DomainUpdatedAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("domain_expires_at")]
    public required DateTimeOffset? DomainExpiresAt { get; init; }

    /// <summary>
    /// Domain registrar.
    /// </summary>
    [JsonPropertyName("registrar")]
    public required string? Registrar { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
