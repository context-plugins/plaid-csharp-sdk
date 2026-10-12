using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines an expected sweep date and amount.
/// </summary>
public record TransferExpectedSweepSettlementScheduleItem
{
    /// <summary>
    /// The settlement date of a sweep for this transfer.
    /// </summary>
    [JsonPropertyName("sweep_settlement_date")]
    public required DateTimeOffset SweepSettlementDate { get; init; }

    /// <summary>
    /// The accumulated amount that has been swept by <c>sweep_settlement_date</c>.
    /// </summary>
    [JsonPropertyName("swept_settled_amount")]
    public required string SweptSettledAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
