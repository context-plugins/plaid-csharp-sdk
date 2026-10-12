using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxPaymentSimulateRequest defines the request schema for <c>/sandbox/payment/simulate</c>
/// </summary>
public record SandboxPaymentSimulateRequest
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
    /// The ID of the payment to simulate
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// The webhook url to use for any payment events triggered by the simulated status change.
    /// </summary>
    [JsonPropertyName("webhook")]
    public required string Webhook { get; init; }

    /// <summary>
    /// The status to set the payment to.
    /// <para>
    /// Valid statuses include:
    /// - <c>PAYMENT_STATUS_INITIATED</c>
    /// - <c>PAYMENT_STATUS_INSUFFICIENT_FUNDS</c>
    /// - <c>PAYMENT_STATUS_FAILED</c>
    /// - <c>PAYMENT_STATUS_EXECUTED</c>
    /// - <c>PAYMENT_STATUS_SETTLED</c>
    /// - <c>PAYMENT_STATUS_CANCELLED</c>
    /// - <c>PAYMENT_STATUS_REJECTED</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
