using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a ledger event in the Transfers API.
/// </summary>
public record TransferLedgerEvent
{
    /// <summary>
    /// Plaid's unique identifier for this ledger event.
    /// </summary>
    [JsonPropertyName("ledger_event_id")]
    public required string LedgerEventId { get; init; }

    /// <summary>
    /// The ID of the ledger this event belongs to.
    /// </summary>
    [JsonPropertyName("ledger_id")]
    public required string LedgerId { get; init; }

    /// <summary>
    /// The amount of the ledger event as a decimal string.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The ID of the transfer source that triggered this ledger event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_id")]
    public string? TransferId { get; init; }

    /// <summary>
    /// The ID of the refund source that triggered this ledger event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_id")]
    public string? RefundId { get; init; }

    /// <summary>
    /// The ID of the sweep source that triggered this ledger event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sweep_id")]
    public string? SweepId { get; init; }

    /// <summary>
    /// A description of the ledger event.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The new pending balance after this event.
    /// </summary>
    [JsonPropertyName("pending_balance")]
    public required string PendingBalance { get; init; }

    /// <summary>
    /// The new available balance after this event.
    /// </summary>
    [JsonPropertyName("available_balance")]
    public required string AvailableBalance { get; init; }

    /// <summary>
    /// The type of balance that was impacted by this event.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// The datetime when this ledger event occurred.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
