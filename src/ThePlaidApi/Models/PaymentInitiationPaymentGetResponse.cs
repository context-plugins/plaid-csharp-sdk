using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentGetResponse defines the response schema for <c>/payment_initiation/payment/get</c>
/// </summary>
public record PaymentInitiationPaymentGetResponse
{
    /// <summary>
    /// The ID of the payment. Like all Plaid identifiers, the <c>payment_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// The amount and currency of a payment
    /// </summary>
    [JsonPropertyName("amount")]
    public required PaymentAmount Amount { get; init; }

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
    [JsonPropertyName("status")]
    public required PaymentInitiationPaymentStatus Status { get; init; }

    /// <summary>
    /// The ID of the recipient
    /// </summary>
    [JsonPropertyName("recipient_id")]
    public required string RecipientId { get; init; }

    /// <summary>
    /// A reference for the payment.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// The value of the reference sent to the bank after adjustment to pass bank validation rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjusted_reference")]
    public string? AdjustedReference { get; init; }

    /// <summary>
    /// The date and time of the last time the <c>status</c> was updated, in ISO 8601 format
    /// </summary>
    [JsonPropertyName("last_status_update")]
    public required DateTimeOffset LastStatusUpdate { get; init; }

    /// <summary>
    /// The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public ExternalPaymentScheduleGet? Schedule { get; init; }

    /// <summary>
    /// Details about external payment refund
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_details")]
    public ExternalPaymentRefundDetails? RefundDetails { get; init; }

    /// <summary>
    /// An object containing a Bacs account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, Bacs data is required.
    /// </summary>
    [JsonPropertyName("bacs")]
    public required SenderBacsNullable? Bacs { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the sender, if specified in the <c>/payment_initiation/payment/create</c> call.
    /// </summary>
    [JsonPropertyName("iban")]
    public required string? Iban { get; init; }

    /// <summary>
    /// Refund IDs associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_ids")]
    public IReadOnlyList<string>? RefundIds { get; init; }

    /// <summary>
    /// The amount and currency of a payment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_refunded")]
    public PaymentAmountRefunded? AmountRefunded { get; init; }

    /// <summary>
    /// The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wallet_id")]
    public string? WalletId { get; init; }

    /// <summary>
    /// Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). In responses, if the scheme is not explicitly specified in the request, this value will be <c>null</c>. Using unsupported values will result in a failed payment.
    /// <para>
    /// <c>LOCAL_DEFAULT</c>: The default payment scheme for the selected market and currency will be used.
    /// </para>
    /// <para>
    /// <c>LOCAL_INSTANT</c>: The instant payment scheme for the selected market and currency will be used (if applicable). Fees may be applied by the institution.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER</c>: The standard payment to a beneficiary within the SEPA area.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER_INSTANT</c>: Instant payment within the SEPA area. May involve additional fees and may not be available at some banks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheme")]
    public PaymentScheme? Scheme { get; init; }

    /// <summary>
    /// Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). In responses, if the scheme is not explicitly specified in the request, this value will be <c>null</c>. Using unsupported values will result in a failed payment.
    /// <para>
    /// <c>LOCAL_DEFAULT</c>: The default payment scheme for the selected market and currency will be used.
    /// </para>
    /// <para>
    /// <c>LOCAL_INSTANT</c>: The instant payment scheme for the selected market and currency will be used (if applicable). Fees may be applied by the institution.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER</c>: The standard payment to a beneficiary within the SEPA area.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER_INSTANT</c>: Instant payment within the SEPA area. May involve additional fees and may not be available at some banks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjusted_scheme")]
    public PaymentScheme? AdjustedScheme { get; init; }

    /// <summary>
    /// The payment consent ID that this payment was initiated with. Is present only when payment was initiated using the payment consent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consent_id")]
    public string? ConsentId { get; init; }

    /// <summary>
    /// The transaction ID that this payment is associated with, if any. This is present only when a payment was initiated using virtual accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_id")]
    public string? TransactionId { get; init; }

    /// <summary>
    /// A unique identifier assigned by Plaid to each payment for tracking and reconciliation purposes.
    /// <para>
    /// Note: Not all banks handle <c>end_to_end_id</c> consistently. To ensure accurate matching, clients should convert both the incoming <c>end_to_end_id</c> and the one provided by Plaid to the same case (either lower or upper) before comparison. For virtual account payments, Plaid manages this field automatically.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_to_end_id")]
    public string? EndToEndId { get; init; }

    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
