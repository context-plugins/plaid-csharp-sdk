using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a transfer within the Transfers API.
/// </summary>
public record Transfer
{
    /// <summary>
    /// Plaid's unique identifier for a transfer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a transfer authorization.
    /// </summary>
    [JsonPropertyName("authorization_id")]
    public required string AuthorizationId { get; init; }

    /// <summary>
    /// Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <see href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</see>.
    /// <para>
    /// Codes supported for credits: <c>ccd</c>, <c>ppd</c>
    /// Codes supported for debits: <c>ccd</c>, <c>ppd</c>, <c>tel</c>, <c>web</c>
    /// </para>
    /// <para>
    /// <c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts
    /// </para>
    /// <para>
    /// <c>"ppd"</c> - Prearranged Payment or Deposit - The transfer is part of a pre-existing relationship with a consumer. Authorization was obtained in writing either in person or via an electronic document signing, e.g. Docusign, by the consumer. Can be used for credits or debits.
    /// </para>
    /// <para>
    /// <c>"web"</c> - Internet-Initiated Entry. The transfer debits a consumer's bank account. Authorization from the consumer is obtained over the Internet (e.g. a web or mobile application). Can be used for single debits or recurring debits.
    /// </para>
    /// <para>
    /// <c>"tel"</c> - Telephone-Initiated Entry. The transfer debits a consumer. Debit authorization has been received orally over the telephone via a recorded call.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach_class")]
    public AchClass? AchClass { get; init; }

    /// <summary>
    /// The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.
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
    /// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required TransferType Type { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required TransferUserInResponse User { get; init; }

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The description of the transfer.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The datetime when this transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c>
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// The status of the transfer.
    /// <para>
    /// <c>pending</c>: A new transfer was created; it is in the pending state.
    /// <c>posted</c>: The transfer has been successfully submitted to the payment network.
    /// <c>settled</c>: The transfer was successfully completed by the payment network. Note that funds from received debits are not available to be moved out of the Ledger until the transfer reaches <c>funds_available</c> status. For credit transactions, <c>settled</c> means the funds have been delivered to the receiving bank account. This is the terminal state of a successful credit transfer.
    /// <c>funds_available</c>: Funds from the transfer have been released from hold and applied to the ledger's available balance. (Only applicable to ACH debits.) This is the terminal state of a successful debit transfer.
    /// <c>cancelled</c>: The transfer was cancelled by the client. This is the terminal state of a cancelled transfer.
    /// <c>failed</c>: The transfer failed, no funds were moved. This is the terminal state of a failed transfer.
    /// <c>returned</c>: A posted transfer was returned. This is the terminal state of a returned transfer.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required TransferStatus Status { get; init; }

    /// <summary>
    /// The status of the sweep for the transfer.
    /// <para>
    /// <c>unswept</c>: The transfer hasn't been swept yet.
    /// <c>swept</c>: The transfer was swept to the sweep account.
    /// <c>swept_settled</c>: Credits are available to be withdrawn or debits have been deducted from the customer's business checking account.
    /// <c>return_swept</c>: The transfer was returned, funds were pulled back or pushed back to the sweep account.
    /// <c>null</c>: The transfer will never be swept (e.g. if the transfer is cancelled or returned before being swept)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sweep_status")]
    public TransferSweepStatus? SweepStatus { get; init; }

    /// <summary>
    /// The network or rails used for the transfer.
    /// <para>
    /// For transfers submitted as <c>ach</c> or <c>same-day-ach</c>, the Standard ACH cutoff is 8:30 PM Eastern Time.
    /// </para>
    /// <para>
    /// For transfers submitted as <c>same-day-ach</c>, the Same Day ACH cutoff is 3:00 PM Eastern Time.  It is recommended to send the request 15 minutes prior to the cutoff to ensure that it will be processed in time for submission before the cutoff. If the transfer is processed after this cutoff but before the Standard ACH cutoff, it will be sent over Standard ACH rails and will not incur same-day charges; this will apply to both legs of the transfer if applicable. The transaction limit for a Same Day ACH transfer is $1,000,000. Authorization requests sent with an amount greater than $1,000,000 will fail.
    /// </para>
    /// <para>
    /// For transfers submitted as <c>rtp</c>, Plaid will automatically route between the Real-Time Payments (RTP) rail by TCH or FedNow rails as necessary. If a transfer is submitted as <c>rtp</c> and the counterparty account is not eligible for RTP, the <c>/transfer/authorization/create</c> request will fail with an <c>INVALID_FIELD</c> error code. To pre-check to determine whether a counterparty account can support RTP, call <c>/transfer/capabilities/get</c> before calling <c>/transfer/authorization/create</c>.
    /// </para>
    /// <para>
    /// Wire transfers are currently in early availability. To request access to <c>wire</c> as a payment network, contact your account manager. For transfers submitted as <c>wire</c>, the <c>type</c> must be <c>credit</c>; wire debits are not supported. The cutoff to submit a wire payment is 6:30 PM Eastern Time on a business day; wires submitted after that time will be processed on the next business day. The transaction limit for a wire is $999,999.99. Authorization requests sent with an amount greater than $999,999.99 will fail.
    /// </para>
    /// <para>
    /// Support for <c>rfp</c> (request for payment) is currently in closed beta. To learn more, contact your Plaid account manager. For transfers submitted as <c>rfp</c>, the <c>type</c> must be <c>debit</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("network")]
    public required TransferNetwork Network { get; init; }

    /// <summary>
    /// Information specific to wire transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wire_details")]
    public TransferWireDetails? WireDetails { get; init; }

    /// <summary>
    /// When <c>true</c>, you can still cancel this transfer.
    /// </summary>
    [JsonPropertyName("cancellable")]
    public required bool Cancellable { get; init; }

    /// <summary>
    /// The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public required TransferFailure? FailureReason { get; init; }

    /// <summary>
    /// The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:
    /// The JSON values must be Strings (no nested JSON objects allowed)
    /// Only ASCII characters may be used
    /// Maximum of 50 key/value pairs
    /// Maximum key length of 40 characters
    /// Maximum value length of 500 characters
    /// </summary>
    [JsonPropertyName("metadata")]
    [MaxProperties(50)]
    public required IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the origination account that was used for this transfer.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string OriginationAccountId { get; init; }

    [JsonPropertyName("guarantee_decision")]
    public required TransferAuthorizationGuaranteeDecision? GuaranteeDecision { get; init; }

    /// <summary>
    /// The rationale for Plaid's decision to not guarantee a transfer. Will be <c>null</c> unless <c>guarantee_decision</c> is <c>NOT_GUARANTEED</c>.
    /// </summary>
    [JsonPropertyName("guarantee_decision_rationale")]
    public required TransferAuthorizationGuaranteeDecisionRationale? GuaranteeDecisionRationale { get; init; }

    /// <summary>
    /// Adaptive guarantee details for a transfer, including the guaranteed amount and settlement schedule. Omitted when no guarantee was attempted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("guarantee_details")]
    public TransferGuaranteeDetails? GuaranteeDetails { get; init; }

    /// <summary>
    /// The currency of the transfer amount, e.g. "USD"
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// The date 3 business days from settlement date indicating the following ACH returns can no longer happen: R01, R02, R03, R29. This will be of the form YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("standard_return_window")]
    public required DateTimeOffset? StandardReturnWindow { get; init; }

    /// <summary>
    /// The date 61 business days from settlement date indicating the following ACH returns can no longer happen: R05, R07, R10, R11, R51, R33, R37, R38, R52, R53. This will be of the form YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("unauthorized_return_window")]
    public required DateTimeOffset? UnauthorizedReturnWindow { get; init; }

    /// <summary>
    /// Deprecated for Plaid Ledger clients, use <c>expected_funds_available_date</c> instead.
    /// </summary>
    [JsonPropertyName("expected_settlement_date")]
    public required DateTimeOffset? ExpectedSettlementDate { get; init; }

    /// <summary>
    /// The expected date when funds from a transfer will be made available and can be withdrawn from the associated ledger balance, assuming the debit does not return before this date. If the transfer does return before this date, this field will be null. Only applies to debit transfers. This will be of the form YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expected_funds_available_date")]
    public DateTimeOffset? ExpectedFundsAvailableDate { get; init; }

    /// <summary>
    /// The Plaid client ID that is the originator of this transfer. Only present if created on behalf of another client as a <see href="https://plaid.com/docs/transfer/application/#originators-vs-platforms">Platform customer</see>.
    /// </summary>
    [JsonPropertyName("originator_client_id")]
    public required string? OriginatorClientId { get; init; }

    /// <summary>
    /// A list of refunds associated with this transfer.
    /// </summary>
    [JsonPropertyName("refunds")]
    public required IReadOnlyList<TransferRefund> Refunds { get; init; }

    /// <summary>
    /// The id of the recurring transfer if this transfer belongs to a recurring transfer.
    /// </summary>
    [JsonPropertyName("recurring_transfer_id")]
    public required string? RecurringTransferId { get; init; }

    /// <summary>
    /// The expected sweep settlement schedule of this transfer, assuming this transfer is not <c>returned</c>. Only applies to ACH debit transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expected_sweep_settlement_schedule")]
    public IReadOnlyList<TransferExpectedSweepSettlementScheduleItem>? ExpectedSweepSettlementSchedule { get; init; }

    [JsonPropertyName("credit_funds_source")]
    public required TransferCreditFundsSource? CreditFundsSource { get; init; }

    /// <summary>
    /// The amount to deduct from <c>transfer.amount</c> and distribute to the platform's Ledger balance as a facilitator fee (decimal string with two digits of precision e.g. "10.00"). The remainder will go to the end-customer's Ledger balance. This must be value greater than 0 and less than or equal to the <c>transfer.amount</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facilitator_fee")]
    public string? FacilitatorFee { get; init; }

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
