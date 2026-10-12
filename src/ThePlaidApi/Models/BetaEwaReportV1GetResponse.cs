using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// BetaEwaReportV1GetResponse defines the response schema for <c>/beta/ewa_report/v1/get</c>
/// </summary>
public record BetaEwaReportV1GetResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    /// <summary>
    /// Unique identifier for the generated EWA score group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ewa_report_id")]
    public string? EwaReportId { get; init; }

    /// <summary>
    /// The date and time when <c>ewa_scores</c> was generated, in ISO 8601 format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generation_time")]
    public DateTimeOffset? GenerationTime { get; init; }

    /// <summary>
    /// A list of earned wage access (EWA) scoring entries that map potential advance amounts to repayment likelihood scores. The predefined advance amount ranges are <c>[0, 25)</c>, <c>[25, 50)</c>, <c>[50, 100)</c>, <c>[100, 200)</c>, <c>[200, 300)</c>, <c>[300, 400)</c>, and <c>[400, 500)</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ewa_scores")]
    public IReadOnlyList<EwaScore>? EwaScores { get; init; }

    /// <summary>
    /// A set of attributes providing context about the factors that contributed to the EWA scores. Each key is the attribute name and the value is its numeric score, or null if the attribute could not be computed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ewa_attributes")]
    public IReadOnlyDictionary<string, double?>? EwaAttributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
