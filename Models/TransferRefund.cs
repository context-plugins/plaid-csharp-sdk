using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a refund within the Transfers API.
/// </summary>
public record TransferRefund
{
    /// <summary>
    /// Plaid's unique identifier for a refund.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The ID of the transfer to refund.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The amount of the refund (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The status of the refund.
    /// <para>
    /// <c>pending</c>: A new refund was created; it is in the pending state.
    /// <c>posted</c>: The refund has been successfully submitted to the payment network.
    /// <c>settled</c>: Credits have been refunded to the Plaid linked account.
    /// <c>cancelled</c>: The refund was cancelled by the client.
    /// <c>failed</c>: The refund has failed.
    /// <c>returned</c>: The refund was returned.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required TransferRefundStatus Status { get; init; }

    /// <summary>
    /// The failure reason if the status for a refund is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public required TransferRefundFailure? FailureReason { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a Plaid Ledger Balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ledger_id")]
    public string? LedgerId { get; init; }

    /// <summary>
    /// The datetime when this refund was created. This will be of the form <c>2006-01-02T15:04:05Z</c>
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// The trace identifier for the transfer based on its network. This will only be set after the transfer has posted.
    /// <para>
    /// For <c>ach</c> or <c>same-day-ach</c> transfers, this is the ACH trace number.
    /// For <c>rtp</c> transfers, this is the Transaction Identification number.
    /// For <c>wire</c> transfers, this is the IMAD (Input Message Accountability Data) number.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_trace_id")]
    public string? NetworkTraceId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
