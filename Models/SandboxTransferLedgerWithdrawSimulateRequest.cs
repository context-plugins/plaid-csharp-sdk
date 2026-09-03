using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/sandbox/transfer/ledger/withdraw/simulate</c>
/// </summary>
public record SandboxTransferLedgerWithdrawSimulateRequest
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
    /// Plaid's unique identifier for a sweep.
    /// </summary>
    [JsonPropertyName("sweep_id")]
    public required string SweepId { get; init; }

    /// <summary>
    /// The asynchronous event to be simulated. May be: <c>posted</c>, <c>settled</c>, <c>failed</c>, or <c>returned</c>.
    /// <para>
    /// An error will be returned if the event type is incompatible with the current ledger sweep status. Compatible status --&gt; event type transitions include:
    /// </para>
    /// <para>
    /// <c>sweep.pending</c> --&gt; <c>sweep.posted</c>
    /// </para>
    /// <para>
    /// <c>sweep.pending</c> --&gt; <c>sweep.failed</c>
    /// </para>
    /// <para>
    /// <c>sweep.posted</c> --&gt; <c>sweep.settled</c>
    /// </para>
    /// <para>
    /// <c>sweep.posted</c> --&gt; <c>sweep.returned</c>
    /// </para>
    /// <para>
    /// <c>sweep.settled</c> --&gt; <c>sweep.returned</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public required TransferLedgerSweepSimulateEventType EventType { get; init; }

    /// <summary>
    /// The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_reason")]
    public TransferFailure? FailureReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
