using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Webhook notifications are sent only when a subscribed issue is marked as resolved. The payload contains details about the issue at the time of its resolution, focusing on the most essential information.
/// </summary>
public record IssueResolvedWebhook
{
    /// <summary>
    /// <c>ISSUES</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>ISSUE_RESOLVED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The unique identifier of the connectivity issue.
    /// </summary>
    [JsonPropertyName("issue_id")]
    public required string IssueId { get; init; }

    /// <summary>
    /// A simple description of the error for the end user.
    /// </summary>
    [JsonPropertyName("issue_description")]
    public required string IssueDescription { get; init; }

    /// <summary>
    /// The time when the issue was marked as resolved.
    /// </summary>
    [JsonPropertyName("issue_resolved_at")]
    public required DateTimeOffset IssueResolvedAt { get; init; }

    /// <summary>
    /// The unique identifier of the financial institution involved.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The name of the financial institution involved.
    /// </summary>
    [JsonPropertyName("institution_name")]
    public required string InstitutionName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
