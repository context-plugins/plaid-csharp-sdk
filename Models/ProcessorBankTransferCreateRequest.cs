using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/processor/bank_transfer/create</c>
/// </summary>
public record ProcessorBankTransferCreateRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// A random key provided by the client, per unique bank transfer. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a bank transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single bank transfer is created.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c>
    /// </summary>
    [JsonPropertyName("processor_token")]
    public required string ProcessorToken { get; init; }

    /// <summary>
    /// The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required BankTransferType Type { get; init; }

    /// <summary>
    /// The network or rails used for the transfer. Valid options are <c>ach</c>, <c>same-day-ach</c>, or <c>wire</c>.
    /// </summary>
    [JsonPropertyName("network")]
    public required BankTransferNetwork Network { get; init; }

    /// <summary>
    /// The amount of the bank transfer (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The currency of the transfer amount - should be set to "USD".
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// The transfer description. Maximum of 10 characters.
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(10)]
    public required string Description { get; init; }

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
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required BankTransferUser User { get; init; }

    /// <summary>
    /// An arbitrary string provided by the client for storage with the bank transfer. May be up to 100 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_tag")]
    [MaxLength(100)]
    public string? CustomTag { get; init; }

    /// <summary>
    /// The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:
    /// The JSON values must be Strings (no nested JSON objects allowed)
    /// Only ASCII characters may be used
    /// Maximum of 50 key/value pairs
    /// Maximum key length of 40 characters
    /// Maximum value length of 500 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    [MaxProperties(50)]
    public IReadOnlyDictionary<string, string?>? Metadata { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origination_account_id")]
    public string? OriginationAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
