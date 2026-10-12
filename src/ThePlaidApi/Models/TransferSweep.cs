using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Describes a sweep of funds to / from the sweep account.
/// <para>
/// A sweep is associated with many sweep events (events of type <c>swept</c> or <c>return_swept</c>) which can be retrieved by invoking the <c>/transfer/event/list</c> endpoint with the corresponding <c>sweep_id</c>.
/// </para>
/// <para>
/// <c>swept</c> events occur when the transfer amount is credited or debited from your sweep account, depending on the <c>type</c> of the transfer. <c>return_swept</c> events occur when a transfer is returned and Plaid undoes the credit or debit.
/// </para>
/// <para>
/// The total sum of the <c>swept</c> and <c>return_swept</c> events is equal to the <c>amount</c> of the sweep Plaid creates and matches the amount of the entry on your sweep account ledger.
/// </para>
/// </summary>
public record TransferSweep
{
    /// <summary>
    /// Identifier of the sweep.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited.
    /// </summary>
    [JsonPropertyName("funding_account_id")]
    public required string FundingAccountId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a Plaid Ledger Balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ledger_id")]
    public string? LedgerId { get; init; }

    /// <summary>
    /// The datetime when the sweep occurred, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. "-10.00")
    /// <para>
    /// If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced.
    /// </para>
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The currency of the sweep, e.g. "USD".
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// The date when the sweep settled, in the YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("settled")]
    public required DateTimeOffset? Settled { get; init; }

    /// <summary>
    /// The expected date when funds from a ledger deposit will be made available and can be withdrawn from the associated ledger balance. Only applies to deposits. This will be of the form YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expected_funds_available_date")]
    public DateTimeOffset? ExpectedFundsAvailableDate { get; init; }

    /// <summary>
    /// The status of a sweep transfer
    /// <para>
    /// <c>"pending"</c> - The sweep is currently pending
    /// <c>"posted"</c> - The sweep has been posted
    /// <c>"settled"</c> - The sweep has settled. This is the terminal state of a successful credit sweep.
    /// <c>"returned"</c> - The sweep has been returned. This is the terminal state of a returned sweep. Returns of a sweep are extremely rare, since sweeps are money movement between your own bank account and your own Ledger.
    /// <c>"funds_available"</c> - Funds from the sweep have been released from hold and applied to the ledger's available balance. (Only applicable to deposits.) This is the terminal state of a successful deposit sweep.
    /// <c>"failed"</c> - The sweep has failed. This is the terminal state of a failed sweep.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public SweepStatus? Status { get; init; }

    /// <summary>
    /// The trigger of the sweep
    /// <para>
    /// <c>"manual"</c> - The sweep is created manually by the customer
    /// <c>"incoming"</c> - The sweep is created by incoming funds flow (e.g. Incoming Wire)
    /// <c>"balance_threshold"</c> - The sweep is created by balance threshold setting
    /// <c>"automatic_aggregate"</c> - The sweep is created by the Plaid automatic aggregation process. These funds did not pass through the Plaid Ledger balance.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trigger")]
    public SweepTrigger? Trigger { get; init; }

    /// <summary>
    /// The description of the deposit that will be passed to the receiving bank (up to 10 characters). Note that banks utilize this field differently, and may or may not show it on the bank statement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

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

    /// <summary>
    /// The failure reason if the status for a sweep is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_reason")]
    public SweepFailure? FailureReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
