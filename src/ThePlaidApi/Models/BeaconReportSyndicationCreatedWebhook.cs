using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when a report created on the Beacon Network matches with one of your Beacon Users.
/// </summary>
public record BeaconReportSyndicationCreatedWebhook
{
    /// <summary>
    /// <c>BEACON</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>REPORT_SYNDICATION_CREATED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The ID of the associated Beacon Report Syndication.
    /// </summary>
    [JsonPropertyName("beacon_report_syndication_id")]
    public required string BeaconReportSyndicationId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
