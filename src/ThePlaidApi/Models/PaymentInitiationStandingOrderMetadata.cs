using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata specifically related to valid Payment Initiation standing order configurations for the institution.
/// </summary>
public record PaymentInitiationStandingOrderMetadata
{
    /// <summary>
    /// Indicates whether the institution supports closed-ended standing orders by providing an end date.
    /// </summary>
    [JsonPropertyName("supports_standing_order_end_date")]
    public required bool SupportsStandingOrderEndDate { get; init; }

    /// <summary>
    /// This is only applicable to <c>MONTHLY</c> standing orders. Indicates whether the institution supports negative integers (-1 to -5) for setting up a <c>MONTHLY</c> standing order relative to the end of the month.
    /// </summary>
    [JsonPropertyName("supports_standing_order_negative_execution_days")]
    public required bool SupportsStandingOrderNegativeExecutionDays { get; init; }

    /// <summary>
    /// A list of the valid standing order intervals supported by the institution.
    /// </summary>
    [JsonPropertyName("valid_standing_order_intervals")]
    public required IReadOnlyList<PaymentScheduleInterval> ValidStandingOrderIntervals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
