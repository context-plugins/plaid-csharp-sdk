using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/authorization/create</c>
/// </summary>
public record TransferAuthorizationCreateRequest
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
    /// Specify the account used to fund the transfer. Should be specified if using legacy funding methods only. If using Plaid Ledger, leave this field blank. Customers can find a list of <c>funding_account_id</c>s in the Accounts page of your Plaid Dashboard, under the "Account ID" column. If this field is left blank and you are using legacy funding methods, this will default to the default <c>funding_account_id</c> specified during onboarding. Otherwise, Plaid Ledger will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funding_account_id")]
    public string? FundingAccountId { get; init; }

    /// <summary>
    /// Specify which ledger balance should be used to fund the transfer. You can find a list of <c>ledger_id</c>s in the Accounts page of your Plaid Dashboard. If this field is left blank, this will default to the id of the default ledger balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ledger_id")]
    public string? LedgerId { get; init; }

    /// <summary>
    /// The payment profile token associated with the Payment Profile that will be debited or credited. Required if not using <c>access_token</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_profile_token")]
    public string? PaymentProfileToken { get; init; }

    /// <summary>
    /// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required TransferType Type { get; init; }

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
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

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
    /// Information specific to wire transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wire_details")]
    public TransferWireDetails? WireDetails { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.  If the account has multiple account holders, provide the information for the account holder on whose behalf the authorization is being requested. The <c>user.legal_name</c> field is required. Other fields are not currently used and are present to support planned future functionality.
    /// </summary>
    [JsonPropertyName("user")]
    public required TransferAuthorizationUserInRequest User { get; init; }

    /// <summary>
    /// Information about the device being used to initiate the authorization. These fields are not currently incorporated into the risk check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public TransferAuthorizationDevice? Device { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the origination account for this authorization. If not specified, the default account will be used.
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
    /// A random key provided by the client, per unique authorization, which expires after 48 hours. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create an authorization fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single authorization is created.
    /// </para>
    /// <para>
    /// Idempotency does not apply to authorizations whose decisions are <c>user_action_required</c>. Therefore you may re-attempt the authorization after completing the required user action without changing <c>idempotency_key</c>.
    /// </para>
    /// <para>
    /// This idempotency key expires after 48 hours, after which the same key can be reused. Failure to provide this key may result in duplicate charges.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// If the end user is initiating the specific transfer themselves via an interactive UI, this should be <c>true</c>; for automatic recurring payments where the end user is not actually initiating each individual transfer, it should be <c>false</c>. This field is not currently used and is present to support planned future functionality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_present")]
    public bool? UserPresent { get; init; }

    /// <summary>
    /// If set to <c>false</c>, Plaid will not offer a <c>guarantee_decision</c> for this request (Guarantee customers only). This field is deprecated in favor of <c>guarantee</c>.
    /// </summary>
    [JsonPropertyName("with_guarantee")]
    public bool? WithGuarantee { get; init; } = true;

    /// <summary>
    /// Indicates whether the transfer should be evaluated for guarantee coverage. When set to <c>true</c>, Plaid assesses the transfer for guarantee coverage and returns a decision in the authorization response. When omitted or set to <c>false</c>, the authorization is evaluated without guarantee coverage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_guarantee")]
    public bool? RequestGuarantee { get; init; }

    /// <summary>
    /// The unique identifier returned by Plaid's <see href="https://plaid.com/docs/transfer/guarantee/#using-a-beacon">beacon</see> when it is run on your webpage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beacon_session_id")]
    public string? BeaconSessionId { get; init; }

    /// <summary>
    /// The Plaid client ID that is the originator of this transfer. Only needed if creating transfers on behalf of another client as a <see href="https://plaid.com/docs/transfer/application/#originators-vs-platforms">Platform customer</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originator_client_id")]
    public string? OriginatorClientId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_funds_source")]
    public TransferCreditFundsSource? CreditFundsSource { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a test clock. This field may only be used when using <c>sandbox</c> environment. If provided, the <c>authorization</c> is created at the <c>virtual_time</c> on the provided test clock.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_clock_id")]
    public string? TestClockId { get; init; }

    /// <summary>
    /// The key of the Ruleset for the transaction. If not provided, Signal will use the <c>default</c> ruleset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleset_key")]
    public string? RulesetKey { get; init; }

    /// <summary>
    /// A free-form map of client-supplied risk-relevant context for this authorization. Plaid may use these attributes to inform future versions of our risk models.
    /// <para>
    /// The following limitations apply:
    /// Keys must match the regular expression <c>^[A-Za-z0-9_.-]{1,40}$</c>
    /// Values must be strings (no nested objects, arrays, numbers, or booleans allowed; stringify non-string values client-side)
    /// Maximum of 50 key/value pairs
    /// Maximum value length of 500 characters
    /// </para>
    /// <para>
    /// Do not include personally identifiable information or other sensitive data.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attributes")]
    [MaxProperties(50)]
    public IReadOnlyDictionary<string, string?>? CustomAttributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
