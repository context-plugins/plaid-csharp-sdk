using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of a payment has changed. For a full explanation of payment statuses and how to handle each, see the <see href="https://plaid.com/docs/payment-initiation/payment-status/">Payment Status guide</see>.
/// <para>
/// Note: For standard Payment Initiation, Plaid payment statuses do not constitute proof that funds have arrived in the recipient's account, and you should not use <c>new_payment_status</c> to confirm fund settlement. For options that provide confirmation of fund receipt, see <see href="https://plaid.com/docs/payment-initiation/virtual-accounts/payment-confirmation/">Virtual Accounts</see>.
/// </para>
/// </summary>
public record PaymentStatusUpdateWebhook
{
    /// <summary>
    /// <c>PAYMENT_INITIATION</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>PAYMENT_STATUS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>payment_id</c> for the payment being updated
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// The transaction ID that this payment is associated with, if any. This is present only when a payment was initiated using virtual accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_id")]
    public string? TransactionId { get; init; }

    /// <summary>
    /// The status of the payment.
    /// <para>
    /// Core lifecycle statuses:
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_INPUT_NEEDED</c></b>: Transitional. The payment is awaiting user input to continue processing. It may re-enter this state if additional input is required.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_AUTHORISING</c>:</b> Transitional. The payment is being authorised by the financial institution. It will automatically move on once authorisation completes.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_INITIATED</c>:</b> The payment has been authorised and accepted by the financial institution. In many EU markets, <c>PAYMENT_STATUS_EXECUTED</c> is not supported, and a payment will remain in <c>PAYMENT_STATUS_INITIATED</c> until the funds settle, making this a terminal success state in those cases. A payment in <c>PAYMENT_STATUS_INITIATED</c> should be treated as a successfully submitted payment; do not gate downstream processing on reaching <c>PAYMENT_STATUS_EXECUTED</c>. For a full explanation of payment statuses and how to handle each, see the <see href="https://plaid.com/docs/payment-initiation/payment-status/">Payment Status guide</see>.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_EXECUTED</c>: Terminal.</b> The funds have left the payer's account and the payment is en route to settlement. Note that this status does not confirm that funds have arrived in the recipient's account; do not use it as proof of fund receipt. Support is more common in the UK than in the EU; where unsupported, a successful payment remains in <c>PAYMENT_STATUS_INITIATED</c> before settling. When using Plaid Virtual Accounts, <c>PAYMENT_STATUS_EXECUTED</c> is not terminal -- the payment will continue to <c>PAYMENT_STATUS_SETTLED</c> once funds are available.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_SETTLED</c>: Terminal.</b> The funds are available in the recipient's account. Only available to customers using <see href="https://plaid.com/docs/payment-initiation/virtual-accounts/">Plaid Virtual Accounts</see>.
    /// </para>
    /// <para>
    /// Failure statuses:
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_INSUFFICIENT_FUNDS</c>: Terminal.</b> The payment failed due to insufficient funds. No further retries will succeed until the payer's balance is replenished.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_FAILED</c>: Terminal (retryable).</b> The payment could not be initiated due to a system error or outage. Retry once the root cause is resolved.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_BLOCKED</c>: Terminal (retryable).</b> The payment was blocked by Plaid (e.g., flagged as risky). Resolve any compliance or risk issues and retry.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_REJECTED</c>: Terminal.</b> The payment was rejected by the financial institution. No automatic retry is possible.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_CANCELLED</c>: Terminal.</b> The end user cancelled the payment during authorisation.
    /// </para>
    /// <para>
    /// Standing-order statuses:
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_ESTABLISHED</c>: Terminal.</b> A recurring/standing order has been successfully created.
    /// </para>
    /// <para>
    /// Deprecated (to be removed in a future release):
    /// </para>
    /// <para>
    /// <c>PAYMENT_STATUS_UNKNOWN</c>: The payment status is unknown.
    /// </para>
    /// <para>
    /// <c>PAYMENT_STATUS_PROCESSING</c>: The payment is currently being processed.
    /// </para>
    /// <para>
    /// <c>PAYMENT_STATUS_COMPLETED</c>: Indicates that the standing order has been successfully established.
    /// </para>
    /// </summary>
    [JsonPropertyName("new_payment_status")]
    public required PaymentInitiationPaymentStatus NewPaymentStatus { get; init; }

    /// <summary>
    /// The status of the payment.
    /// <para>
    /// Core lifecycle statuses:
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_INPUT_NEEDED</c></b>: Transitional. The payment is awaiting user input to continue processing. It may re-enter this state if additional input is required.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_AUTHORISING</c>:</b> Transitional. The payment is being authorised by the financial institution. It will automatically move on once authorisation completes.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_INITIATED</c>:</b> The payment has been authorised and accepted by the financial institution. In many EU markets, <c>PAYMENT_STATUS_EXECUTED</c> is not supported, and a payment will remain in <c>PAYMENT_STATUS_INITIATED</c> until the funds settle, making this a terminal success state in those cases. A payment in <c>PAYMENT_STATUS_INITIATED</c> should be treated as a successfully submitted payment; do not gate downstream processing on reaching <c>PAYMENT_STATUS_EXECUTED</c>. For a full explanation of payment statuses and how to handle each, see the <see href="https://plaid.com/docs/payment-initiation/payment-status/">Payment Status guide</see>.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_EXECUTED</c>: Terminal.</b> The funds have left the payer's account and the payment is en route to settlement. Note that this status does not confirm that funds have arrived in the recipient's account; do not use it as proof of fund receipt. Support is more common in the UK than in the EU; where unsupported, a successful payment remains in <c>PAYMENT_STATUS_INITIATED</c> before settling. When using Plaid Virtual Accounts, <c>PAYMENT_STATUS_EXECUTED</c> is not terminal -- the payment will continue to <c>PAYMENT_STATUS_SETTLED</c> once funds are available.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_SETTLED</c>: Terminal.</b> The funds are available in the recipient's account. Only available to customers using <see href="https://plaid.com/docs/payment-initiation/virtual-accounts/">Plaid Virtual Accounts</see>.
    /// </para>
    /// <para>
    /// Failure statuses:
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_INSUFFICIENT_FUNDS</c>: Terminal.</b> The payment failed due to insufficient funds. No further retries will succeed until the payer's balance is replenished.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_FAILED</c>: Terminal (retryable).</b> The payment could not be initiated due to a system error or outage. Retry once the root cause is resolved.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_BLOCKED</c>: Terminal (retryable).</b> The payment was blocked by Plaid (e.g., flagged as risky). Resolve any compliance or risk issues and retry.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_REJECTED</c>: Terminal.</b> The payment was rejected by the financial institution. No automatic retry is possible.
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_CANCELLED</c>: Terminal.</b> The end user cancelled the payment during authorisation.
    /// </para>
    /// <para>
    /// Standing-order statuses:
    /// </para>
    /// <para>
    /// <b><c>PAYMENT_STATUS_ESTABLISHED</c>: Terminal.</b> A recurring/standing order has been successfully created.
    /// </para>
    /// <para>
    /// Deprecated (to be removed in a future release):
    /// </para>
    /// <para>
    /// <c>PAYMENT_STATUS_UNKNOWN</c>: The payment status is unknown.
    /// </para>
    /// <para>
    /// <c>PAYMENT_STATUS_PROCESSING</c>: The payment is currently being processed.
    /// </para>
    /// <para>
    /// <c>PAYMENT_STATUS_COMPLETED</c>: Indicates that the standing order has been successfully established.
    /// </para>
    /// </summary>
    [JsonPropertyName("old_payment_status")]
    public required PaymentInitiationPaymentStatus OldPaymentStatus { get; init; }

    /// <summary>
    /// The original value of the reference when creating the payment.
    /// </summary>
    [JsonPropertyName("original_reference")]
    public required string? OriginalReference { get; init; }

    /// <summary>
    /// The value of the reference sent to the bank after adjustment to pass bank validation rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjusted_reference")]
    public string? AdjustedReference { get; init; }

    /// <summary>
    /// The original value of the <c>start_date</c> provided during the creation of a standing order. If the payment is not a standing order, this field will be <c>null</c>.
    /// </summary>
    [JsonPropertyName("original_start_date")]
    public required DateTimeOffset? OriginalStartDate { get; init; }

    /// <summary>
    /// The start date sent to the bank after adjusting for holidays or weekends.  Will be provided in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD). If the start date did not require adjustment, or if the payment is not a standing order, this field will be <c>null</c>.
    /// </summary>
    [JsonPropertyName("adjusted_start_date")]
    public required DateTimeOffset? AdjustedStartDate { get; init; }

    /// <summary>
    /// The timestamp of the update, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
