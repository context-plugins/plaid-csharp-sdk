using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<TransferEventType>))]
public sealed record TransferEventType : StringEnum<TransferEventType>
{
    private TransferEventType(string value) : base(value)
    {
    }

    public static readonly TransferEventType Pending = new("pending");

    public static readonly TransferEventType Cancelled = new("cancelled");

    public static readonly TransferEventType Failed = new("failed");

    public static readonly TransferEventType Posted = new("posted");

    public static readonly TransferEventType Settled = new("settled");

    public static readonly TransferEventType FundsAvailable = new("funds_available");

    public static readonly TransferEventType Guaranteed = new("guaranteed");

    public static readonly TransferEventType Returned = new("returned");

    public static readonly TransferEventType GuaranteeReimbursed = new("guarantee_reimbursed");

    public static readonly TransferEventType ClientReturnRecovered = new("client_return_recovered");

    public static readonly TransferEventType PlaidReturnRecovered = new("plaid_return_recovered");

    public static readonly TransferEventType Swept = new("swept");

    public static readonly TransferEventType SweptSettled = new("swept_settled");

    public static readonly TransferEventType ReturnSwept = new("return_swept");

    public static readonly TransferEventType SweepPending = new("sweep.pending");

    public static readonly TransferEventType SweepPosted = new("sweep.posted");

    public static readonly TransferEventType SweepSettled = new("sweep.settled");

    public static readonly TransferEventType SweepReturned = new("sweep.returned");

    public static readonly TransferEventType SweepFailed = new("sweep.failed");

    public static readonly TransferEventType SweepFundsAvailable = new("sweep.funds_available");

    public static readonly TransferEventType RefundPending = new("refund.pending");

    public static readonly TransferEventType RefundCancelled = new("refund.cancelled");

    public static readonly TransferEventType RefundFailed = new("refund.failed");

    public static readonly TransferEventType RefundPosted = new("refund.posted");

    public static readonly TransferEventType RefundSettled = new("refund.settled");

    public static readonly TransferEventType RefundReturned = new("refund.returned");

    public static readonly TransferEventType RefundSwept = new("refund.swept");

    public static readonly TransferEventType RefundReturnSwept = new("refund.return_swept");

    public static TransferEventType FromValue(string value) => FromValueCore(value);
}
