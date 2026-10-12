using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of a wallet transaction has changed.
/// </summary>
public record WalletTransactionStatusUpdateWebhook
{
    /// <summary>
    /// <c>WALLET</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>WALLET_TRANSACTION_STATUS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>transaction_id</c> for the wallet transaction being updated
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// The <c>payment_id</c> associated with the transaction. This will be present in case of <c>REFUND</c> and <c>PIS_PAY_IN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// The EMI (E-Money Institution) wallet that this payment is associated with. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wallet_id")]
    public string? WalletId { get; init; }

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
    [JsonPropertyName("new_status")]
    public required WalletTransactionStatus NewStatus { get; init; }

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
    [JsonPropertyName("old_status")]
    public required WalletTransactionStatus OldStatus { get; init; }

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
