using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// WalletTransactionExecuteRequest defines the request schema for <c>/wallet/transaction/execute</c>
/// </summary>
public record WalletTransactionExecuteRequest
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
    /// A random key provided by the client, per unique wallet transaction. Maximum of 128 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a wallet transaction fails due to a network connection error, then after a minimum delay of one minute, you can retry the request with the same idempotency key to guarantee that only a single wallet transaction is created. If the request was successfully processed, it will prevent any transaction that uses the same idempotency key, and was received within 24 hours of the first request, from being processed.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The ID of the e-wallet to debit from
    /// </summary>
    [JsonPropertyName("wallet_id")]
    [MinLength(1)]
    public required string WalletId { get; init; }

    /// <summary>
    /// An object representing the e-wallet transaction's counterparty
    /// </summary>
    [JsonPropertyName("counterparty")]
    public required WalletTransactionCounterparty Counterparty { get; init; }

    /// <summary>
    /// The amount and currency of a transaction
    /// </summary>
    [JsonPropertyName("amount")]
    public required WalletTransactionAmount Amount { get; init; }

    /// <summary>
    /// A reference for the transaction. This must be an alphanumeric string with 6 to 18 characters and must not contain any special characters or spaces.
    /// Ensure that the <c>reference</c> field is unique for each transaction.
    /// </summary>
    [JsonPropertyName("reference")]
    [StringLength(18, MinimumLength = 6)]
    public required string Reference { get; init; }

    /// <summary>
    /// The original source of the funds. This field is required by local regulation for certain businesses (e.g. money remittance) to send payouts to recipients in the EU and UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originating_fund_source")]
    public OriginatingFundSource? OriginatingFundSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
