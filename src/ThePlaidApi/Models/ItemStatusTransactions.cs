using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the last successful and failed transactions update for the Item.
/// </summary>
public record ItemStatusTransactions
{
    /// <summary>
    /// <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> timestamp of the last successful transactions update for the Item. The status will update each time Plaid successfully connects with the institution, regardless of whether any new data is available in the update. This field does not reflect transactions updates performed by non-Transactions products (e.g. Signal).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_successful_update")]
    public DateTimeOffset? LastSuccessfulUpdate { get; init; }

    /// <summary>
    /// <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> timestamp of the last failed transactions update for the Item. The status will update each time Plaid fails an attempt to connect with the institution, regardless of whether any new data is available in the update. This field does not reflect transactions updates performed by non-Transactions products (e.g. Signal).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_failed_update")]
    public DateTimeOffset? LastFailedUpdate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
