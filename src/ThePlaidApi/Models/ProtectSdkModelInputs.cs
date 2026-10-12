using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Inputs for Protect SDK Trust Index models.
/// </summary>
public record ProtectSdkModelInputs
{
    /// <summary>
    /// A unique identifier for the Protect SDK session, used to compute a Trust Index score and fraud attributes.
    /// </summary>
    [JsonPropertyName("sdk_session_id")]
    [MaxLength(128)]
    public required string SdkSessionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
