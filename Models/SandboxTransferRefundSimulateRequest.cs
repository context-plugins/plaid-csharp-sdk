using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/sandbox/transfer/refund/simulate</c>
/// </summary>
public record SandboxTransferRefundSimulateRequest
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
    /// Plaid's unique identifier for a refund.
    /// </summary>
    [JsonPropertyName("refund_id")]
    public required string RefundId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a test clock. If provided, the event to be simulated is created at the <c>virtual_time</c> on the provided <c>test_clock</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_clock_id")]
    public string? TestClockId { get; init; }

    /// <summary>
    /// The asynchronous event to be simulated. May be: <c>refund.posted</c>, <c>refund.settled</c>, <c>refund.failed</c>, or <c>refund.returned</c>.
    /// <para>
    /// An error will be returned if the event type is incompatible with the current refund status. Compatible status --&gt; event type transitions include:
    /// </para>
    /// <para>
    /// <c>refund.pending</c> --&gt; <c>refund.failed</c>
    /// </para>
    /// <para>
    /// <c>refund.pending</c> --&gt; <c>refund.posted</c>
    /// </para>
    /// <para>
    /// <c>refund.posted</c> --&gt; <c>refund.returned</c>
    /// </para>
    /// <para>
    /// <c>refund.posted</c> --&gt; <c>refund.settled</c>
    /// </para>
    /// <para>
    /// <c>refund.posted</c> events can only be simulated if the refunded transfer has been transitioned to settled. This mimics the ordering of events in Production.
    /// </para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public required string EventType { get; init; }

    /// <summary>
    /// The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_reason")]
    public TransferFailure? FailureReason { get; init; }

    /// <summary>
    /// The webhook URL to which a <c>TRANSFER_EVENTS_UPDATE</c> webhook should be sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
