using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A single entry in the adaptive guarantee settlement schedule, describing one tranche of guaranteed funds. Adds <c>observation_window_expiration_time</c>, which is only known once a transfer is created.
/// </summary>
public record TransferGuaranteeScheduleItem
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

    /// <summary>
    /// The datetime when the observation window for this tranche expires. Present only when the tranche is subject to an observation window. This will be of the form <c>2006-01-02T15:04:05Z</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("observation_window_expiration_time")]
    public DateTimeOffset? ObservationWindowExpirationTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
