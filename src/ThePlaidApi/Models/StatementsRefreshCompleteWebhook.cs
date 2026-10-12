using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when refreshed statements extraction is completed or failed to be completed. Triggered by calling <c>/statements/refresh</c>.
/// </summary>
public record StatementsRefreshCompleteWebhook
{
    /// <summary>
    /// <c>STATEMENTS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>STATEMENTS_REFRESH_COMPLETE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The result of the statement refresh extraction
    /// <para>
    /// <c>SUCCESS</c>: The statements were successfully extracted and can be listed via <c>/statements/list</c> and downloaded via <c>/statements/download</c>.
    /// </para>
    /// <para>
    /// <c>FAILURE</c>: The statements failed to be extracted.
    /// </para>
    /// </summary>
    [JsonPropertyName("result")]
    public required StatementsRefreshCompleteResult Result { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
