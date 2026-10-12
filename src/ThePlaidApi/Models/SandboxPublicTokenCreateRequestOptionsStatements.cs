using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional set of parameters corresponding to statements options.
/// </summary>
public record SandboxPublicTokenCreateRequestOptionsStatements
{
    /// <summary>
    /// The earliest date for which to fetch statements history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The most recent date for which to fetch statements history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
