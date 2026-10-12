using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/refund/create</c>
/// </summary>
public record TransferRefundCreateRequest
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
    /// The ID of the transfer to refund.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The amount of the refund (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// A random key provided by the client, per unique refund. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a refund fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single refund is created.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public required string IdempotencyKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
