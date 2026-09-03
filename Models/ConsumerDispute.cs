using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The information about a previously submitted valid dispute statement by the consumer
/// </summary>
public record ConsumerDispute
{
    /// <summary>
    /// (Deprecated) A unique identifier (UUID) of the consumer dispute that can be used for troubleshooting
    /// </summary>
    [JsonPropertyName("consumer_dispute_id")]
    public required string ConsumerDisputeId { get; init; }

    /// <summary>
    /// Date of the disputed field (e.g. transaction date), in an ISO 8601 format (YYYY-MM-DD)
    /// </summary>
    [JsonPropertyName("dispute_field_create_date")]
    public required DateTimeOffset DisputeFieldCreateDate { get; init; }

    /// <summary>
    /// Type of data being disputed by the consumer
    /// </summary>
    [JsonPropertyName("category")]
    public required ConsumerReportCategory Category { get; init; }

    /// <summary>
    /// Text content of dispute
    /// </summary>
    [JsonPropertyName("statement")]
    public required string Statement { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
