using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/recurring/create</c>
/// </summary>
public record TransferRecurringCreateRequest
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
    /// A random key provided by the client, per unique recurring transfer. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a recurring transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single recurring transfer is created.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Specify the account used to fund the transfer. Customers can find a list of <c>funding_account_id</c>s in the Accounts page of your Plaid Dashboard, under the "Account ID" column. If this field is left blank, it will default to the default <c>funding_account_id</c> specified during onboarding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funding_account_id")]
    public string? FundingAccountId { get; init; }

    /// <summary>
    /// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required TransferType Type { get; init; }

    /// <summary>
    /// Networks eligible for recurring transfers.
    /// </summary>
    [JsonPropertyName("network")]
    public required TransferRecurringNetwork Network { get; init; }

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
    /// The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// If the end user is initiating the specific transfer themselves via an interactive UI, this should be <c>true</c>; for automatic recurring payments where the end user is not actually initiating each individual transfer, it should be <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_present")]
    public bool? UserPresent { get; init; }

    /// <summary>
    /// The currency of the transfer amount. The default value is "USD".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The description of the recurring transfer.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a test clock. This field may only be used when using the <c>sandbox</c> environment. If provided, the created <c>recurring_transfer</c> is associated with the <c>test_clock</c>. New originations are automatically generated when the associated <c>test_clock</c> advances. For more details, see <see href="https://plaid.com/docs/transfer/sandbox/#simulating-recurring-transfers">Simulating recurring transfers</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_clock_id")]
    public string? TestClockId { get; init; }

    /// <summary>
    /// The schedule that the recurring transfer will be executed on.
    /// </summary>
    [JsonPropertyName("schedule")]
    public required TransferRecurringSchedule Schedule { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required TransferUserInRequest User { get; init; }

    /// <summary>
    /// Information about the device being used to initiate the authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public TransferDevice? Device { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
