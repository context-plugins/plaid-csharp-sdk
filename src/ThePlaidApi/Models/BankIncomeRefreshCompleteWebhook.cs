using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when a refreshed bank income report has finished generating or failed to generate. To obtain refreshed Bank Income data, send the user through Link's update mode, or migrate to CRA Income Insights and call <c>/cra/check_report/create</c> for a backend refresh. To get this webhook, subscribe via the <see href="https://dashboard.plaid.com/developers/webhooks">Dashboard</see>.
/// </summary>
public record BankIncomeRefreshCompleteWebhook
{
    /// <summary>
    /// <c>INCOME</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>BANK_INCOME_REFRESH_COMPLETE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>user_id</c> corresponding to the user the webhook has fired for.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// The result of the bank income refresh report generation
    /// <para>
    /// <c>SUCCESS</c>: The refreshed report was successfully generated and can be retrieved via <c>/credit/bank_income/get</c>.
    /// </para>
    /// <para>
    /// <c>FAILURE</c>: The refreshed report failed to be generated
    /// </para>
    /// </summary>
    [JsonPropertyName("result")]
    public required BankIncomeRefreshCompleteResult Result { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
