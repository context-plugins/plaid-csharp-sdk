using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Adaptive guarantee details for a transfer authorization, including the guarantee outcome and settlement schedule. Omitted when no guarantee was attempted.
/// </summary>
public record AuthorizationGuaranteeDetails
{
    /// <summary>
    /// The adaptive guarantee outcome for a transfer.
    /// <para>
    /// <c>FULL_INSTANT</c>: The full transfer amount is guaranteed and funds are available instantly.
    /// </para>
    /// <para>
    /// <c>PARTIAL_INSTANT_ONLY</c>: A partial amount is guaranteed and available instantly; the remainder is not guaranteed.
    /// </para>
    /// <para>
    /// <c>PARTIAL_INSTANT_WITH_OBSERVATION_WINDOW</c>: A partial amount is guaranteed instantly; an additional amount is conditionally guaranteed subject to an observation window.
    /// </para>
    /// <para>
    /// <c>NOT_GUARANTEED</c>: Plaid did not provide a guarantee for this transfer.
    /// </para>
    /// </summary>
    [JsonPropertyName("outcome")]
    public required TransferGuaranteeOutcome Outcome { get; init; }

    /// <summary>
    /// The adaptive guarantee settlement schedule for this authorization.
    /// </summary>
    [JsonPropertyName("schedule")]
    public required IReadOnlyList<AuthorizationGuaranteeScheduleItem> Schedule { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
