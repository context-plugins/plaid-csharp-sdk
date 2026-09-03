using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a recurring transfer within the Transfers API.
/// </summary>
public record RecurringTransferNullable
{
    /// <summary>
    /// Plaid's unique identifier for a recurring transfer.
    /// </summary>
    [JsonPropertyName("recurring_transfer_id")]
    public required string RecurringTransferId { get; init; }

    /// <summary>
    /// The datetime when this transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c>
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// A date in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// <para>
    /// The next transfer origination date after bank holiday adjustment.
    /// </para>
    /// </summary>
    [JsonPropertyName("next_origination_date")]
    public required DateTimeOffset? NextOriginationDate { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a test clock.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_clock_id")]
    public string? TestClockId { get; init; }

    /// <summary>
    /// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required TransferType Type { get; init; }

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The status of the recurring transfer.
    /// <para>
    /// <c>active</c>: The recurring transfer is currently active.
    /// <c>cancelled</c>: The recurring transfer was cancelled by the client or Plaid.
    /// <c>expired</c>: The recurring transfer has completed all originations according to its recurring schedule.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required TransferRecurringStatus Status { get; init; }

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
    /// Networks eligible for recurring transfers.
    /// </summary>
    [JsonPropertyName("network")]
    public required TransferRecurringNetwork Network { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the origination account that was used for this transfer.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string OriginationAccountId { get; init; }

    /// <summary>
    /// The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited.
    /// </summary>
    [JsonPropertyName("funding_account_id")]
    public required string FundingAccountId { get; init; }

    /// <summary>
    /// The currency of the transfer amount, e.g. "USD"
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// The description of the recurring transfer.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The created transfer instances associated with this <c>recurring_transfer_id</c>. If the recurring transfer has been newly created, this array will be empty.
    /// </summary>
    [JsonPropertyName("transfer_ids")]
    public required IReadOnlyList<string> TransferIds { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required TransferUserInResponse User { get; init; }

    /// <summary>
    /// The schedule that the recurring transfer will be executed on.
    /// </summary>
    [JsonPropertyName("schedule")]
    public required TransferRecurringSchedule Schedule { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
