using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/sandbox/bank_transfer/simulate</c>
/// </summary>
public record SandboxBankTransferSimulateRequest
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
    /// Plaid's unique identifier for a bank transfer.
    /// </summary>
    [JsonPropertyName("bank_transfer_id")]
    public required string BankTransferId { get; init; }

    /// <summary>
    /// The asynchronous event to be simulated. May be: <c>posted</c>, <c>failed</c>, or <c>reversed</c>.
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
    /// <c>posted</c> --&gt; <c>reversed</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public required string EventType { get; init; }

    /// <summary>
    /// The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_reason")]
    public BankTransferFailure? FailureReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
