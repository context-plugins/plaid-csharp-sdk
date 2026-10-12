using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/create</c>
/// </summary>
public record TransferCreateRequest
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
    /// Deprecated. <c>authorization_id</c> is now used as idempotency instead.
    /// <para>
    /// A random key provided by the client, per unique transfer. Maximum of 50 characters.
    /// </para>
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single transfer is created.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// The Plaid <c>access_token</c> for the account that will be debited or credited.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a transfer authorization. This parameter also serves the purpose of acting as an idempotency identifier.
    /// </summary>
    [JsonPropertyName("authorization_id")]
    public required string AuthorizationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TransferType? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network")]
    public TransferNetwork? Network { get; init; }

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public string? Amount { get; init; }

    /// <summary>
    /// The transfer description, maximum of 15 characters (RTP transactions) or 10 characters (ACH transactions). Should represent why the money is moving, not your company name. For recommendations on setting the <c>description</c> field to avoid ACH returns, see <see href="https://www.plaid.com/docs/transfer/creating-transfers/#description-field-recommendations">Description field recommendations</see>.
    /// <para>
    /// If reprocessing a returned transfer, the <c>description</c> field must be <c>"Retry 1"</c> or <c>"Retry 2"</c>. You may retry a transfer up to 2 times, within 180 days of creating the original transfer. Only transfers that were returned with code <c>R01</c> or <c>R09</c> may be retried.
    /// </para>
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(15)]
    public required string Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach_class")]
    public AchClass? AchClass { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public TransferUserInRequestDeprecated? User { get; init; }

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
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified. Otherwise, this field should be left blank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origination_account_id")]
    public string? OriginationAccountId { get; init; }

    /// <summary>
    /// The currency of the transfer amount. The default value is "USD".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a test clock. This field may only be used when using <c>sandbox</c> environment. If provided, the <c>transfer</c> is created at the <c>virtual_time</c> on the provided <c>test_clock</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_clock_id")]
    public string? TestClockId { get; init; }

    /// <summary>
    /// The amount to deduct from <c>transfer.amount</c> and distribute to the platform's Ledger balance as a facilitator fee (decimal string with two digits of precision e.g. "10.00"). The remainder will go to the end-customer's Ledger balance. This must be value greater than 0 and less than or equal to the <c>transfer.amount</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facilitator_fee")]
    public string? FacilitatorFee { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
