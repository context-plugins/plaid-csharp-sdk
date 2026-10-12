using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Request object for /protect/compute
/// </summary>
public record ProtectComputeRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The name of the Trust Index model to use for scoring, with a major.minor version suffix. Examples: <c>ti-link-session-2.0</c> (link-session fraud), <c>ti-identity-2.0</c> (identity fraud), <c>cash-advance-onboarding-1.0</c> (first cash advance), and <c>cash-advance-ongoing-1.0</c> (subsequent cash advances). The model specified may require certain fields within <c>model_inputs</c>; for example, <c>ti-link-session-2.0</c> requires the <c>link</c> field. Cash-advance models do not use <c>model_inputs</c>.
    /// </summary>
    [JsonPropertyName("model")]
    [MaxLength(128)]
    public required string Model { get; init; }

    /// <summary>
    /// Represents an end user for <c>/protect/compute</c> requests.
    /// </summary>
    [JsonPropertyName("user")]
    public required ProtectUser User { get; init; }

    /// <summary>
    /// Inputs required by certain Trust Index models. The <c>link</c> field is required for link-session models. Other model families (including cash-advance) are identified by <c>user</c> alone and do not use this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_inputs")]
    public ProtectModelInputs? ModelInputs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
