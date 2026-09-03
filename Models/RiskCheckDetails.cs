using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional information for the <c>risk_check</c> step.
/// </summary>
public record RiskCheckDetails
{
    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("status")]
    public required IdentityVerificationStepStatus Status { get; init; }

    /// <summary>
    /// Result summary object specifying values for <c>behavior</c> attributes of risk check, when available.
    /// </summary>
    [JsonPropertyName("behavior")]
    public required RiskCheckBehavior? Behavior { get; init; }

    /// <summary>
    /// Result summary object specifying values for <c>email</c> attributes of risk check.
    /// </summary>
    [JsonPropertyName("email")]
    public required RiskCheckEmail? Email { get; init; }

    /// <summary>
    /// Result summary object specifying values for <c>phone</c> attributes of risk check.
    /// </summary>
    [JsonPropertyName("phone")]
    public required RiskCheckPhone? Phone { get; init; }

    /// <summary>
    /// Array of result summary objects specifying values for <c>device</c> attributes of risk check.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<RiskCheckDevice> Devices { get; init; }

    /// <summary>
    /// Result summary object capturing abuse signals related to <c>identity abuse</c>, e.g. stolen and synthetic identity fraud. These attributes are only available for US identities and some signals may not be available depending on what information was collected.
    /// </summary>
    [JsonPropertyName("identity_abuse_signals")]
    public required RiskCheckIdentityAbuseSignals? IdentityAbuseSignals { get; init; }

    /// <summary>
    /// Result summary object specifying values for network attributes of risk check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network")]
    public RiskCheckNetwork? Network { get; init; }

    /// <summary>
    /// The attributes related to the facial duplicates captured in risk check.
    /// </summary>
    [JsonPropertyName("facial_duplicates")]
    public required IReadOnlyList<RiskCheckFacialDuplicate> FacialDuplicates { get; init; }

    /// <summary>
    /// The trust index score for the <c>risk_check</c> step.
    /// </summary>
    [JsonPropertyName("trust_index_score")]
    public required int? TrustIndexScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
