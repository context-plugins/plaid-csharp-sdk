using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/ledger/withdraw</c>
/// </summary>
public record TransferLedgerWithdrawRequest
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
    /// Specify which ledger balance to withdraw from. Customers can find a list of <c>ledger_id</c>s in the Accounts page of your Plaid Dashboard. If this field is left blank, this will default to the id of the default ledger balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ledger_id")]
    public string? LedgerId { get; init; }

    /// <summary>
    /// A positive amount of how much will be withdrawn from the ledger balance (decimal string with two digits of precision e.g. "5.50").
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
    /// A unique key provided by the client, per unique ledger withdraw. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying the request without accidentally performing the same operation twice. For example, if a request to create a ledger withdraw fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single withdraw is created.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public required string IdempotencyKey { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
