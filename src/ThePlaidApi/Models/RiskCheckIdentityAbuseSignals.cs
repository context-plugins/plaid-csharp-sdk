using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object capturing abuse signals related to <c>identity abuse</c>, e.g. stolen and synthetic identity fraud. These attributes are only available for US identities and some signals may not be available depending on what information was collected.
/// </summary>
public record RiskCheckIdentityAbuseSignals
{
    /// <summary>
    /// Field containing the data used in determining the outcome of the synthetic identity risk check.
    /// <para>
    /// Contains the following fields:
    /// </para>
    /// <para>
    /// <c>score</c> - A score from 0 to 100 indicating the likelihood that the user is a synthetic identity.
    /// </para>
    /// </summary>
    [JsonPropertyName("synthetic_identity")]
    public required RiskCheckSyntheticIdentity? SyntheticIdentity { get; init; }

    /// <summary>
    /// Field containing the data used in determining the outcome of the stolen identity risk check.
    /// <para>
    /// Contains the following fields:
    /// </para>
    /// <para>
    /// <c>score</c> - A score from 0 to 100 indicating the likelihood that the user is a stolen identity.
    /// </para>
    /// </summary>
    [JsonPropertyName("stolen_identity")]
    public required RiskCheckStolenIdentity? StolenIdentity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
