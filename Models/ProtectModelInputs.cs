using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Inputs required by certain Trust Index models. The <c>link</c> field is required for link-session models. Other model families (including cash-advance) are identified by <c>user</c> alone and do not use this object.
/// </summary>
public record ProtectModelInputs
{
    /// <summary>
    /// Inputs for link session Trust Index models.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public ProtectLinkModelInputs? Link { get; init; }

    /// <summary>
    /// Inputs for Protect SDK Trust Index models.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdk")]
    public ProtectSdkModelInputs? Sdk { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
