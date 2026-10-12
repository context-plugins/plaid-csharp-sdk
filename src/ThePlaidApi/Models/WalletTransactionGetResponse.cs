using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// WalletTransactionGetResponse defines the response schema for <c>/wallet/transaction/get</c>
/// </summary>
public record WalletTransactionGetResponse
{
    /// <summary>
    /// A unique ID identifying the transaction
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// The ID of the e-wallet that this transaction is associated with.
    /// </summary>
    [JsonPropertyName("wallet_id")]
    public required string WalletId { get; init; }

    /// <summary>
    /// A reference for the transaction
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// The type of the transaction. The supported transaction types that are returned are:
    /// <c>BANK_TRANSFER:</c> a transaction which credits an e-wallet through an external bank transfer.
    /// <para>
    /// <c>PAYOUT:</c> a transaction which debits an e-wallet by disbursing funds to a counterparty.
    /// </para>
    /// <para>
    /// <c>PIS_PAY_IN:</c> a payment which credits an e-wallet through Plaid's Payment Initiation Services (PIS) APIs. For more information see the <see href="https://plaid.com/docs/api/products/payment-initiation/">Payment Initiation endpoints</see>.
    /// </para>
    /// <para>
    /// <c>REFUND:</c> a transaction which debits an e-wallet by refunding a previously initiated payment made through Plaid's <see href="https://plaid.com/docs/api/products/payment-initiation/">PIS APIs</see>.
    /// </para>
    /// <para>
    /// <c>FUNDS_SWEEP</c>: an automated transaction which debits funds from an e-wallet to a designated client-owned account.
    /// </para>
    /// <para>
    /// <c>RETURN</c>: an automated transaction where a debit transaction was reversed and money moved back to originating account.
    /// </para>
    /// <para>
    /// <c>RECALL</c>: a transaction where the sending bank has requested the return of funds due to a fraud claim, technical error, or other issue associated with the payment.
    /// </para>
    /// <para>
    /// <c>ACCOUNT_FUNDING</c>: an incoming transfer from an allowlisted account. Not automatically refunded.
    /// </para>
    /// <para>
    /// <c>AUTO_REFUND</c>: an outgoing refund automatically initiated by Plaid in response to an unexpected <c>BANK_TRANSFER</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type5 Type { get; init; }

    /// <summary>
    /// The payment scheme used to execute this transaction. This is present only for transaction types <c>PAYOUT</c> and <c>REFUND</c>.
    /// <para>
    /// <c>FASTER_PAYMENTS</c>: The standard payment scheme within the UK.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER</c>: The standard payment to a beneficiary within the SEPA area.
    /// </para>
    /// <para>
    /// <c>SEPA_CREDIT_TRANSFER_INSTANT</c>: Instant payment to a beneficiary within the SEPA area.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheme")]
    public WalletPaymentScheme? Scheme { get; init; }

    /// <summary>
    /// The amount and currency of a transaction
    /// </summary>
    [JsonPropertyName("amount")]
    public required WalletTransactionAmount Amount { get; init; }

    /// <summary>
    /// An object representing the e-wallet transaction's counterparty
    /// </summary>
    [JsonPropertyName("counterparty")]
    public required WalletTransactionCounterparty Counterparty { get; init; }

    /// <summary>
    /// The status of the transaction.
    /// <para>
    /// <c>AUTHORISING</c>: The transaction is being processed for validation and compliance.
    /// </para>
    /// <para>
    /// <c>INITIATED</c>: The transaction has been initiated and is currently being processed.
    /// </para>
    /// <para>
    /// <c>EXECUTED</c>: The transaction has been successfully executed and is considered complete. This is only applicable for debit transactions.
    /// </para>
    /// <para>
    /// <c>SETTLED</c>: The transaction has settled and funds are available for use. This is only applicable for credit transactions. A transaction will typically settle within seconds to several days, depending on which payment rail is used.
    /// </para>
    /// <para>
    /// <c>FAILED</c>: The transaction failed to process successfully. This is a terminal status.
    /// </para>
    /// <para>
    /// <c>BLOCKED</c>: The transaction has been blocked for violating compliance rules. This is a terminal status.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required WalletTransactionStatus Status { get; init; }

    /// <summary>
    /// Timestamp when the transaction was created, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The date and time of the last time the <c>status</c> was updated, in ISO 8601 format
    /// </summary>
    [JsonPropertyName("last_status_update")]
    public required DateTimeOffset LastStatusUpdate { get; init; }

    /// <summary>
    /// Result of payee verification check for EUR payouts. Payee verification checks whether the payee name provided matches the account holder name at the destination institution.
    /// <para>
    /// <c>FULL_MATCH</c>: The payee name fully matches the account holder.
    /// </para>
    /// <para>
    /// <c>PARTIAL_MATCH</c>: The payee name partially matches the account holder.
    /// </para>
    /// <para>
    /// <c>NO_MATCH</c>: The payee name does not match the account holder.
    /// </para>
    /// <para>
    /// <c>ERROR</c>: An error occurred during payee verification.
    /// </para>
    /// <para>
    /// <c>CHECK_NOT_POSSIBLE</c>: Payee verification could not be performed.
    /// </para>
    /// <para>
    /// This field is only populated for applicable EUR payout transactions and will be <c>null</c> for other transaction types.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payee_verification_status")]
    public WalletTransactionPayeeVerificationStatus? PayeeVerificationStatus { get; init; }

    /// <summary>
    /// The payment id that this transaction is associated with, if any. This is present only for transaction types <c>PIS_PAY_IN</c> and <c>REFUND</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// The error code of a failed transaction. Error codes include:
    /// <c>EXTERNAL_SYSTEM</c>: The transaction was declined by an external system.
    /// <c>EXPIRED</c>: The transaction request has expired.
    /// <c>CANCELLED</c>: The transaction request was rescinded.
    /// <c>INVALID</c>: The transaction did not meet certain criteria, such as an inactive account or no valid counterparty, etc.
    /// <c>ACCOUNT_INVALID</c>: The transaction could not be processed because the wallet account is invalid or inactive.
    /// <c>AUTHENTICATION_FAILED</c>: The transaction could not be processed because authentication with the wallet provider failed.
    /// <c>UNKNOWN</c>: The transaction was unsuccessful, but the exact cause is unknown.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_reason")]
    public WalletTransactionFailureReason? FailureReason { get; init; }

    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// A list of wallet transactions that this transaction is associated with, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("related_transactions")]
    public IReadOnlyList<WalletTransactionRelation>? RelatedTransactions { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
