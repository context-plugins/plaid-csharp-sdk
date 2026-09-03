using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// This webhook is only sent to <see href="https://plaid.com/docs/auth/partnerships/">Plaid processor partners</see>.
/// <para>
/// Fired when recurring transactions data is updated. This includes when a new recurring stream is detected or when a new transaction is added to an existing recurring stream. The <c>RECURRING_TRANSACTIONS_UPDATE</c> webhook will also fire when one or more attributes of the recurring stream changes, which is usually a result of the addition, update, or removal of transactions to the stream.
/// </para>
/// <para>
/// After receipt of this webhook, the updated data can be fetched from <c>/processor/transactions/recurring/get</c>.
/// </para>
/// </summary>
public record ProcessorRecurringTransactionsUpdateWebhook
{
    /// <summary>
    /// <c>TRANSACTIONS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>RECURRING_TRANSACTIONS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The ID of the account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
