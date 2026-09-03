using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a bank transfer within the Bank Transfers API.
/// </summary>
public record BankTransfer
{
    /// <summary>
    /// Plaid's unique identifier for a bank transfer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

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
    [JsonPropertyName("ach_class")]
    public required AchClass AchClass { get; init; }

    /// <summary>
    /// The account ID that should be credited/debited for this bank transfer.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required BankTransferType Type { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required BankTransferUser User { get; init; }

    /// <summary>
    /// The amount of the bank transfer (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The currency of the transfer amount, e.g. "USD"
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// The description of the transfer.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The datetime when this bank transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c>
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// The status of the transfer.
    /// </summary>
    [JsonPropertyName("status")]
    public required BankTransferStatus Status { get; init; }

    /// <summary>
    /// The network or rails used for the transfer. Valid options are <c>ach</c>, <c>same-day-ach</c>, or <c>wire</c>.
    /// </summary>
    [JsonPropertyName("network")]
    public required BankTransferNetwork Network { get; init; }

    /// <summary>
    /// When <c>true</c>, you can still cancel this bank transfer.
    /// </summary>
    [JsonPropertyName("cancellable")]
    public required bool Cancellable { get; init; }

    /// <summary>
    /// The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public required BankTransferFailure? FailureReason { get; init; }

    /// <summary>
    /// A string containing the custom tag provided by the client in the create request. Will be null if not provided.
    /// </summary>
    [JsonPropertyName("custom_tag")]
    public required string? CustomTag { get; init; }

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
    public required IReadOnlyDictionary<string, string?> Metadata { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the origination account that was used for this transfer.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string OriginationAccountId { get; init; }

    /// <summary>
    /// Indicates the direction of the transfer: <c>outbound</c> for API-initiated transfers, or <c>inbound</c> for payments received by the FBO account.
    /// </summary>
    [JsonPropertyName("direction")]
    public required BankTransferDirection? Direction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
