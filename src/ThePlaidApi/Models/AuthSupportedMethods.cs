using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata specifically related to which auth methods an institution supports.
/// </summary>
public record AuthSupportedMethods
{
    /// <summary>
    /// Indicates if instant auth is supported.
    /// </summary>
    [JsonPropertyName("instant_auth")]
    public required bool InstantAuth { get; init; }

    /// <summary>
    /// Indicates if instant match is supported.
    /// </summary>
    [JsonPropertyName("instant_match")]
    public required bool InstantMatch { get; init; }

    /// <summary>
    /// Indicates if automated micro-deposits are supported.
    /// </summary>
    [JsonPropertyName("automated_micro_deposits")]
    public required bool AutomatedMicroDeposits { get; init; }

    /// <summary>
    /// Indicates if instant micro-deposits are supported.
    /// </summary>
    [JsonPropertyName("instant_micro_deposits")]
    public required bool InstantMicroDeposits { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
