using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A single entry in an authorization's adaptive guarantee settlement schedule, describing one tranche of guaranteed funds.
/// </summary>
public record AuthorizationGuaranteeScheduleItem
{
    /// <summary>
    /// The guaranteed amount for this schedule entry (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The number of business days in the observation window for this tranche. <c>0</c> when the tranche is not subject to an observation window.
    /// </summary>
    [JsonPropertyName("observation_window_business_days")]
    public required int ObservationWindowBusinessDays { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
