using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Statements product. This field is required for the statements product.
/// </summary>
public record LinkTokenCreateRequestStatements
{
    /// <summary>
    /// The start date for statements, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> "YYYY-MM-DD" format, e.g. "2020-10-30".
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The end date for statements, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> "YYYY-MM-DD" format, e.g. "2020-10-30". You can request up to two years of data.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
