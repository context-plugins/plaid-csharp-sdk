using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when a new transfer of a recurring transfer is originated.
/// </summary>
public record RecurringNewTransferWebhook
{
    /// <summary>
    /// <c>TRANSFER</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>RECURRING_NEW_TRANSFER</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a recurring transfer.
    /// </summary>
    [JsonPropertyName("recurring_transfer_id")]
    public required string RecurringTransferId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a transfer.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
