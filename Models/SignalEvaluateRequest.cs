using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SignalEvaluateRequest defines the request schema for <c>/signal/evaluate</c>
/// </summary>
public record SignalEvaluateRequest
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
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// The Plaid <c>account_id</c> of the account that is the funding source for the proposed transaction. The <c>account_id</c> is returned in the <c>/accounts/get</c> endpoint as well as the <see href="https://plaid.com/docs/link/ios/#link-ios-onsuccess-linkSuccess-metadata-accounts-id"><c>onSuccess</c></see> callback metadata.
    /// <para>
    /// This will return an <see href="https://plaid.com/docs/errors/invalid-input/#invalid_account_id"><c>INVALID_ACCOUNT_ID</c></see> error if the account has been removed at the bank or if the <c>account_id</c> is no longer valid.
    /// </para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The unique ID that you would like to use to refer to this evaluation attempt - for example, a payment attempt ID. You will use this later to debug this evaluation, and/or report an ACH return, etc. The max length for this field is 36 characters. The <c>client_transaction_id</c> also functions as an idempotency key; calling <c>/signal/evaluate</c> with a previously used <c>client_transaction_id</c> will return the results of the previous evaluation rather than triggering a fresh evaluation.
    /// </summary>
    [JsonPropertyName("client_transaction_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string ClientTransactionId { get; init; }

    /// <summary>
    /// The transaction amount, in USD (e.g. <c>102.05</c>)
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// <c>true</c> if the end user is present while initiating the ACH transfer and the endpoint is being called; <c>false</c> otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing). When using a Balance-only ruleset, this field is ignored. This field is not currently used as part of Signal Transaction Score evaluations, but may be used in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_present")]
    public bool? UserPresent { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

    /// <summary>
    /// Use <c>true</c> if the ACH transaction is a part of recurring schedule (for example, a monthly repayment); <c>false</c> otherwise. When using a Balance-only ruleset, this field is ignored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_recurring")]
    public bool? IsRecurring { get; init; }

    /// <summary>
    /// The default ACH payment method to complete the transaction. When using a Balance-only ruleset, this field is ignored.
    /// <c>SAME_DAY_ACH</c>: Same Day ACH by Nacha. The debit transaction is processed and settled on the same day.
    /// <c>STANDARD_ACH</c>: Standard ACH by Nacha.
    /// <c>MULTIPLE_PAYMENT_METHODS</c>: If there is no default debit rail or there are multiple payment methods.
    /// Possible values:  <c>SAME_DAY_ACH</c>, <c>STANDARD_ACH</c>, <c>MULTIPLE_PAYMENT_METHODS</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_payment_method")]
    public string? DefaultPaymentMethod { get; init; }

    /// <summary>
    /// Details about the end user initiating the transaction (i.e., the account holder). These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only ruleset, if the Signal Addendum has been signed, these fields are ignored; if the Addendum has not been signed, using these fields will result in an error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public SignalUser? User { get; init; }

    /// <summary>
    /// Details about the end user's device. These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only Ruleset, these fields are ignored if the Signal Addendum has been signed; if it has not been signed, using these fields will result in an error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public SignalEvaluateDevice? Device { get; init; }

    /// <summary>
    /// Specifying <c>risk_profile_key</c> is deprecated. Please provide <c>ruleset</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_profile_key")]
    public string? RiskProfileKey { get; init; }

    /// <summary>
    /// The key of the ruleset to use for evaluating this transaction. You can create a ruleset using the Plaid Dashboard, under <see href="https://dashboard.plaid.com/signal/risk-profiles">Signal-&gt;Rules</see>. If not provided, for all new customers as of October 15, 2025, the <c>default</c> ruleset will be used. For existing Signal Transaction Scores customers as of October 15, 2025, by default, no ruleset will be used if the <c>ruleset_key</c> is not provided. For more information, or to opt out of using rulesets, see <see href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleset_key")]
    public string? RulesetKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
