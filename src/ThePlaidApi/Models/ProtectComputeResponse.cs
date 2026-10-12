using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Response object for /protect/compute
/// </summary>
public record ProtectComputeResponse
{
    /// <summary>
    /// The Trust Index score, on a 0-100 scale where higher values indicate lower risk.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public int? Score { get; init; }

    /// <summary>
    /// The versioned name of the Trust Index model used for scoring.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// Event fraud attributes as an arbitrary set of key-value pairs. The set of attributes returned varies by model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public object? Attributes { get; init; }

    /// <summary>
    /// Per-bucket subscores returned alongside the overall Trust Index score. For cash-advance models, each key maps to an amount-bucket subscore (0-100); higher values indicate lower fraud risk. Only buckets that were scored are included in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscores")]
    public ProtectComputeSubscores? Subscores { get; init; }

    /// <summary>
    /// The timestamp when the Trust Index score and fraud attributes were computed, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
