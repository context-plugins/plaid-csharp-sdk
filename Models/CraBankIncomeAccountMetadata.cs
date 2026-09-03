using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing metadata about the extracted account.
/// </summary>
public record CraBankIncomeAccountMetadata
{
    /// <summary>
    /// The date of the earliest extracted transaction, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The date of the most recent extracted transaction, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
