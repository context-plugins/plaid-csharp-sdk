using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/ledger/deposit</c>
/// </summary>
public record TransferLedgerDepositRequest
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
    /// Client ID of the customer that owns the Ledger balance. This is so Plaid knows which of your customers to pay out to or collect funds from. Only applicable for <see href="https://plaid.com/docs/transfer/application/#originators-vs-platforms">Platform customers</see>. Do not include if you're paying out to yourself.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originator_client_id")]
    public string? OriginatorClientId { get; init; }

    /// <summary>
    /// Specify which funding account to use. Customers can find a list of <c>funding_account_id</c>s in the Accounts page of the Plaid Dashboard, under the "Account ID" column. If this field is left blank, the funding account associated with the specified Ledger will be used. If an <c>originator_client_id</c> is specified, the <c>funding_account_id</c> must belong to the specified originator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funding_account_id")]
    public string? FundingAccountId { get; init; }

    /// <summary>
    /// Specify which ledger balance to deposit to. Customers can find a list of <c>ledger_id</c>s in the Accounts page of your Plaid Dashboard. If this field is left blank, this will default to the id of the default ledger balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ledger_id")]
    public string? LedgerId { get; init; }

    /// <summary>
    /// A positive amount of how much will be deposited into ledger (decimal string with two digits of precision e.g. "5.50").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The description of the deposit that will be passed to the receiving bank (up to 10 characters). Note that banks utilize this field differently, and may or may not show it on the bank statement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(10)]
    public string? Description { get; init; }

    /// <summary>
    /// A unique key provided by the client, per unique ledger deposit. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying the request without accidentally performing the same operation twice. For example, if a request to create a ledger deposit fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single deposit is created.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The ACH networks used for the funds flow.
    /// <para>
    /// For requests submitted as either <c>ach</c> or <c>same-day-ach</c> the cutoff for Same Day ACH is 3:00 PM Eastern Time and the cutoff for Standard ACH transfers is 8:30 PM Eastern Time. It is recommended to submit a request at least 15 minutes before the cutoff time in order to ensure that it will be processed before the cutoff. Any request that is indicated as <c>same-day-ach</c> and that misses the Same Day ACH cutoff, but is submitted in time for the Standard ACH cutoff, will be sent over Standard ACH rails and will not incur same-day charges.
    /// </para>
    /// </summary>
    [JsonPropertyName("network")]
    public required TransferAchNetwork Network { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
