using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Originator and their status.
/// </summary>
public record Originator
{
    /// <summary>
    /// Originator's client ID.
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; init; }

    /// <summary>
    /// Originator's diligence status.
    /// </summary>
    [JsonPropertyName("transfer_diligence_status")]
    public required TransferDiligenceStatus TransferDiligenceStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
