using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Adaptive guarantee details for a transfer, including the guaranteed amount and settlement schedule. Omitted when no guarantee was attempted.
/// </summary>
public record TransferGuaranteeDetails
{
    /// <summary>
    /// The amount currently covered by Plaid's guarantee (decimal string with two digits of precision e.g. "10.00"). This may change over time as scheduled tranches reach their observation window expiration and become guaranteed.
    /// </summary>
    [JsonPropertyName("guaranteed_amount")]
    public required string GuaranteedAmount { get; init; }

    /// <summary>
    /// The adaptive guarantee settlement schedule for this transfer.
    /// </summary>
    [JsonPropertyName("schedule")]
    public required IReadOnlyList<TransferGuaranteeScheduleItem> Schedule { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
