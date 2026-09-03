using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/event/sync</c>
/// </summary>
public record TransferEventSyncRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The latest (largest) <c>event_id</c> fetched via the sync endpoint, or 0 initially.
    /// </summary>
    [JsonPropertyName("after_id")]
    [Minimum(0)]
    public required int AfterId { get; init; }

    /// <summary>
    /// The maximum number of transfer events to return.
    /// </summary>
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(500)]
    public int? Count { get; init; } = 100;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
