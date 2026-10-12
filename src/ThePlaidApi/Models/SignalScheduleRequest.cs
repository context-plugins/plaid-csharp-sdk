using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// SignalScheduleRequest defines the request schema for <c>/signal/schedule</c>
/// </summary>
public record SignalScheduleRequest
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
    /// The payment method specified in the <c>default_payment_method</c> field directly impacts the timing recommendations provided by the API for submitting the debit entry to your processor or ODFI. If unspecified, defaults to <c>STANDARD_ACH</c>.
    /// <para>
    /// <c>SAME_DAY_ACH</c>: Same Day ACH (as defined by Nacha). The API assumes the settlement will occur on the same business day if the <c>/signal/schedule</c> request is submitted by 6:00 PM UTC. Note: The actual cutoff time can vary depending on your payment processor or ODFI. Nacha has established three processing windows for Same Day ACH (Eastern Time): 10:30 AM, 2:45 PM, and 4:45 PM.
    /// </para>
    /// <para>
    /// <c>STANDARD_ACH</c>: Standard ACH (as defined by Nacha), typically settled one to three business days after submission.
    /// </para>
    /// <para>
    /// <c>MULTIPLE_PAYMENT_METHODS</c>: Indicates that there is no default debit rail or multiple payment methods are available, and the transaction could use any of them based on customer policy or availability.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_payment_method")]
    public SignalScheduleDefaultPaymentMethod? DefaultPaymentMethod { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
