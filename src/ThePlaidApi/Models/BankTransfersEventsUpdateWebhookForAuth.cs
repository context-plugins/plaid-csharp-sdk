using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when new ACH events are available. To begin receiving this webhook, you must first register your webhook listener endpoint via the <see href="https://dashboard.plaid.com/team/webhooks">webhooks page in the Dashboard</see>. The <c>BANK_TRANSFERS_EVENTS_UPDATE</c> webhook can be used to track the progress of ACH transfers used in <see href="https://plaid.com/docs/auth/coverage/microdeposit-events/">micro-deposit verification</see>. Receiving this webhook indicates you should fetch the new events from <c>/bank_transfer/event/sync</c>. Note that <see href="https://plaid.com/docs/transfer">Transfer</see> customers should use Transfer webhooks instead of using <c>BANK_TRANSFERS_EVENTS_UPDATE</c>; see <see href="https://plaid.com/docs/auth/coverage/microdeposit-events/">micro-deposit events documentation</see> for more details.
/// </summary>
public record BankTransfersEventsUpdateWebhookForAuth
{
    /// <summary>
    /// <c>BANK_TRANSFERS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>BANK_TRANSFERS_EVENTS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
