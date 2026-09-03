using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/intent/create</c>
/// </summary>
public record TransferIntentCreateRequest
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
    /// The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// Specify the account used to fund the transfer. Should be specified if using legacy funding methods only. If using Plaid Ledger, leave this field blank. Customers can find a list of <c>funding_account_id</c>s in the Accounts page of your Plaid Dashboard, under the "Account ID" column. If this field is left blank and you are using legacy funding methods, this will default to the default <c>funding_account_id</c> specified during onboarding. Otherwise, Plaid Ledger will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funding_account_id")]
    public string? FundingAccountId { get; init; }

    /// <summary>
    /// The direction of the flow of transfer funds.
    /// <para>
    /// <c>PAYMENT</c>: Transfers funds from an end user's account to your business account.
    /// </para>
    /// <para>
    /// <c>DISBURSEMENT</c>: Transfers funds from your business account to an end user's account.
    /// </para>
    /// </summary>
    [JsonPropertyName("mode")]
    public required TransferIntentCreateMode Mode { get; init; }

    /// <summary>
    /// The network or rails used for the transfer. Defaults to <c>same-day-ach</c>.
    /// <para>
    /// For transfers submitted using <c>ach</c>, the Standard ACH cutoff is 8:30 PM Eastern Time.
    /// </para>
    /// <para>
    /// For transfers submitted using <c>same-day-ach</c>, the Same Day ACH cutoff is 3:00 PM Eastern Time. It is recommended to send the request 15 minutes prior to the cutoff to ensure that it will be processed in time for submission before the cutoff. If the transfer is processed after this cutoff but before the Standard ACH cutoff, it will be sent over Standard ACH rails and will not incur same-day charges.
    /// </para>
    /// <para>
    /// For transfers submitted using <c>rtp</c>, in the case that the account being credited does not support RTP, the transfer will be sent over ACH as long as an <c>ach_class</c> is provided in the request. If RTP isn't supported by the account and no <c>ach_class</c> is provided, the transfer will fail to be submitted.
    /// </para>
    /// </summary>
    [JsonPropertyName("network")]
    public TransferIntentCreateNetwork? Network { get; init; } = TransferIntentCreateNetwork.SameDayAch;

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// A description for the underlying transfer. Maximum of 15 characters.
    /// </summary>
    [JsonPropertyName("description")]
    [StringLength(15, MinimumLength = 1)]
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
    /// Plaid's unique identifier for the origination account for the intent. If not provided, the default account will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origination_account_id")]
    public string? OriginationAccountId { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required TransferUserInRequest User { get; init; }

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
    /// The currency of the transfer amount, e.g. "USD"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// When <c>true</c>, the transfer requires a <c>GUARANTEED</c> decision by Plaid to proceed (Guarantee customers only).
    /// </summary>
    [JsonPropertyName("require_guarantee")]
    public bool? RequireGuarantee { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
