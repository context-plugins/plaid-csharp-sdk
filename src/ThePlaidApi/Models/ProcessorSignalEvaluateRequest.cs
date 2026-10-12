using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorSignalEvaluateRequest defines the request schema for <c>/processor/signal/evaluate</c>
/// </summary>
public record ProcessorSignalEvaluateRequest
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
    /// The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c>
    /// </summary>
    [JsonPropertyName("processor_token")]
    public required string ProcessorToken { get; init; }

    /// <summary>
    /// The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal ID/identifier for this transaction. The max length for this field is 36 characters.
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
    /// <c>true</c> if the end user is present while initiating the ACH transfer and the endpoint is being called; <c>false</c> otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing).
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
    /// <b>true</b> if the ACH transaction is a recurring transaction; <b>false</b> otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_recurring")]
    public bool? IsRecurring { get; init; }

    /// <summary>
    /// The default ACH payment method to complete the transaction.
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
    /// The key of the ruleset to use for this transaction. You can configure a ruleset using the Plaid Dashboard, under <see href="https://dashboard.plaid.com/signal/risk-profiles">Signal-&gt;Rules</see>. If not provided, for customers who began using Signal Transaction Scores before October 15, 2025, by default, no ruleset will be used; for customers who began using Signal Transaction Scores after that date, or for Balance customers, the <c>default</c> ruleset will be used. For more details, or to opt out of using a ruleset, see <see href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleset_key")]
    public string? RulesetKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
