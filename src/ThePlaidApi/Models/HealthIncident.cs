using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A status health incident
/// </summary>
public record HealthIncident
{
    /// <summary>
    /// The start date of the incident, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2020-10-30T15:26:48Z"</c>.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The end date of the incident, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2020-10-30T15:26:48Z"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The title of the incident
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    /// <summary>
    /// Updates on the health incident.
    /// </summary>
    [JsonPropertyName("incident_updates")]
    public required IReadOnlyList<IncidentUpdate> IncidentUpdates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
