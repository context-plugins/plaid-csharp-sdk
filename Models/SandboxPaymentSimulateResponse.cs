using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxPaymentSimulateResponse defines the response schema for <c>/sandbox/payment/simulate</c>
/// </summary>
public record SandboxPaymentSimulateResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

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
    [JsonPropertyName("old_status")]
    public required PaymentInitiationPaymentStatus OldStatus { get; init; }

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
    [JsonPropertyName("new_status")]
    public required PaymentInitiationPaymentStatus NewStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
