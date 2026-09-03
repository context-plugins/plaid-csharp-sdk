using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/ledger/distribute</c>
/// </summary>
public record TransferLedgerDistributeRequest
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
    /// The Ledger to pull money from.
    /// </summary>
    [JsonPropertyName("from_ledger_id")]
    public required string FromLedgerId { get; init; }

    /// <summary>
    /// The Ledger to credit money to.
    /// </summary>
    [JsonPropertyName("to_ledger_id")]
    public required string ToLedgerId { get; init; }

    /// <summary>
    /// The amount to move (decimal string with two digits of precision e.g. "10.00"). Amount must be positive.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// A unique key provided by the client, per unique ledger distribute. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying the request without accidentally performing the same operation twice. For example, if a request to create a ledger distribute fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single distribute is created.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// An optional description for the ledger distribute operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
