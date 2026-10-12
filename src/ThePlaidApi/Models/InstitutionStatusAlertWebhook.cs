using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when institution status meets the conditions configured in the developer dashboard.
/// </summary>
public record InstitutionStatusAlertWebhook
{
    /// <summary>
    /// <c>DASHBOARD_CONFIGURED_ALERT</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>INSTITUTION_STATUS_ALERT_TRIGGERED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The ID of the associated institution.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The global success rate of the institution, calculated based on item add health.
    /// </summary>
    [JsonPropertyName("institution_overall_success_rate")]
    public required double InstitutionOverallSuccessRate { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
