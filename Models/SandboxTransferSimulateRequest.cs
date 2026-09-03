using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/sandbox/transfer/simulate</c>
/// </summary>
public record SandboxTransferSimulateRequest
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
    /// Plaid's unique identifier for a transfer.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a test clock. If provided, the event to be simulated is created at the <c>virtual_time</c> on the provided <c>test_clock</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_clock_id")]
    public string? TestClockId { get; init; }

    /// <summary>
    /// The asynchronous event to be simulated. May be: <c>posted</c>, <c>settled</c>, <c>failed</c>, <c>funds_available</c>, or <c>returned</c>.
    /// <para>
    /// An error will be returned if the event type is incompatible with the current transfer status. Compatible status --&gt; event type transitions include:
    /// </para>
    /// <para>
    /// <c>pending</c> --&gt; <c>failed</c>
    /// </para>
    /// <para>
    /// <c>pending</c> --&gt; <c>posted</c>
    /// </para>
    /// <para>
    /// <c>posted</c> --&gt; <c>returned</c>
    /// </para>
    /// <para>
    /// <c>posted</c> --&gt; <c>settled</c>
    /// </para>
    /// <para>
    /// <c>settled</c> --&gt; <c>funds_available</c> (only applicable to ACH debits.)
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
