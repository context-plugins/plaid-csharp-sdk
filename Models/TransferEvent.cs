using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents an event in the Transfers API.
/// </summary>
public record TransferEvent
{
    /// <summary>
    /// Plaid's unique identifier for this event. IDs are sequential unsigned 64-bit integers.
    /// </summary>
    [JsonPropertyName("event_id")]
    [Minimum(0)]
    public required int EventId { get; init; }

    /// <summary>
    /// The datetime when this event occurred. This will be of the form <c>2006-01-02T15:04:05Z</c>.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// The type of event that this transfer represents. Event types with prefix <c>sweep</c> represent events for Plaid Ledger sweeps.
    /// <para>
    /// <c>pending</c>: A new transfer was created; it is in the pending state.
    /// </para>
    /// <para>
    /// <c>cancelled</c>: The transfer was cancelled by the client.
    /// </para>
    /// <para>
    /// <c>failed</c>: The transfer failed, no funds were moved.
    /// </para>
    /// <para>
    /// <c>posted</c>: The transfer has been successfully submitted to the payment network.
    /// </para>
    /// <para>
    /// <c>settled</c>: The transfer has been successfully completed by the payment network.
    /// </para>
    /// <para>
    /// <c>funds_available</c>: Funds from the transfer have been released from hold and applied to the ledger's available balance. (Only applicable to ACH debits.)
    /// </para>
    /// <para>
    /// <c>guaranteed</c>: The transfer has been fully guaranteed by Plaid.
    /// </para>
    /// <para>
    /// <c>returned</c>: A posted transfer was returned.
    /// </para>
    /// <para>
    /// <c>guarantee_reimbursed</c>: Plaid reimbursed the client for the loss on a returned guaranteed transfer. The <c>event_amount</c> is the reimbursed amount.
    /// </para>
    /// <para>
    /// <c>client_return_recovered</c>: The client reported recovering the loss on a returned transfer via <c>/transfer/return/recover</c>, and Plaid debited the recovered amount from the client's ledger. The <c>event_amount</c> is the recovered amount.
    /// </para>
    /// <para>
    /// <c>plaid_return_recovered</c>: Plaid recovered the loss on a returned transfer by successfully reinitiating it. The <c>event_amount</c> is the recovered amount. Client should stop their return recovery effort.
    /// </para>
    /// <para>
    /// <c>swept</c>: The transfer was swept to / from the sweep account.
    /// </para>
    /// <para>
    /// <c>swept_settled</c>: Credits are available to be withdrawn or debits have been deducted from the customer's business checking account.
    /// </para>
    /// <para>
    /// <c>return_swept</c>: Due to the transfer being returned, funds were pulled from or pushed back to the sweep account.
    /// </para>
    /// <para>
    /// <c>sweep.pending</c>: A new ledger sweep was created; it is in the pending state.
    /// </para>
    /// <para>
    /// <c>sweep.posted</c>: The ledger sweep has been successfully submitted to the payment network.
    /// </para>
    /// <para>
    /// <c>sweep.settled</c>: The transaction has settled in the funding account. This means that funds withdrawn from Plaid Ledger balance have reached the funding account, or funds to be deposited into the Plaid Ledger Balance have been pulled, and the hold period has begun.
    /// </para>
    /// <para>
    /// <c>sweep.returned</c>: A posted ledger sweep was returned.
    /// </para>
    /// <para>
    /// <c>sweep.failed</c>: The ledger sweep failed, no funds were moved.
    /// </para>
    /// <para>
    /// <c>sweep.funds_available</c>: Funds from the ledger sweep have been released from hold and applied to the ledger's available balance. This is only applicable to debits.
    /// </para>
    /// <para>
    /// <c>refund.pending</c>: A new refund was created; it is in the pending state.
    /// </para>
    /// <para>
    /// <c>refund.cancelled</c>: The refund was cancelled.
    /// </para>
    /// <para>
    /// <c>refund.failed</c>: The refund failed, no funds were moved.
    /// </para>
    /// <para>
    /// <c>refund.posted</c>: The refund has been successfully submitted to the payment network.
    /// </para>
    /// <para>
    /// <c>refund.settled</c>: The refund transaction has settled in the Plaid linked account.
    /// </para>
    /// <para>
    /// <c>refund.returned</c>: A posted refund was returned.
    /// </para>
    /// <para>
    /// <c>refund.swept</c>: The refund was swept from the sweep account.
    /// </para>
    /// <para>
    /// <c>refund.return_swept</c>: Due to the refund being returned, funds were pushed back to the sweep account.
    /// </para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public required TransferEventType EventType { get; init; }

    /// <summary>
    /// The account ID associated with the transfer. This field is omitted for Plaid Ledger Sweep events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// The id of the associated funding account, available in the Plaid Dashboard. If present, this indicates which of your business checking accounts will be credited or debited.
    /// </summary>
    [JsonPropertyName("funding_account_id")]
    public required string? FundingAccountId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a Plaid Ledger Balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ledger_id")]
    public string? LedgerId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a transfer. This field is an empty string for Plaid Ledger Sweep events.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The ID of the origination account that this balance belongs to.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string? OriginationAccountId { get; init; }

    /// <summary>
    /// The type of transfer. Valid values are <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account. This field is omitted for Plaid Ledger Sweep events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_type")]
    public OmittableTransferType? TransferType { get; init; }

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). This field is omitted for Plaid Ledger Sweep events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_amount")]
    public string? TransferAmount { get; init; }

    /// <summary>
    /// The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public required TransferFailure? FailureReason { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a sweep.
    /// </summary>
    [JsonPropertyName("sweep_id")]
    public required string? SweepId { get; init; }

    /// <summary>
    /// A signed amount of how much was <c>swept</c> or <c>return_swept</c> for this transfer (decimal string with two digits of precision e.g. "-5.50").
    /// </summary>
    [JsonPropertyName("sweep_amount")]
    public required string? SweepAmount { get; init; }

    /// <summary>
    /// A signed amount associated with this event (decimal string with two digits of precision e.g. "10.00" or "-10.00").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_amount")]
    public string? EventAmount { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a refund. A non-null value indicates the event is for the associated refund of the transfer.
    /// </summary>
    [JsonPropertyName("refund_id")]
    public required string? RefundId { get; init; }

    /// <summary>
    /// The Plaid client ID that is the originator of the transfer that this event applies to. Only present if the transfer was created on behalf of another client as a third-party sender (TPS).
    /// </summary>
    [JsonPropertyName("originator_client_id")]
    public required string? OriginatorClientId { get; init; }

    /// <summary>
    /// The <c>id</c> returned by the <c>/transfer/intent/create</c> endpoint, for transfers created via Transfer UI. For transfers not created by Transfer UI, the value is <c>null</c>. This will currently only be populated for RfP transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intent_id")]
    public string? IntentId { get; init; }

    /// <summary>
    /// The fee amount deducted from the original transfer during a wire return, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wire_return_fee")]
    public string? WireReturnFee { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
