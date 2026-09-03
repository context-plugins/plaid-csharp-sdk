using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the Check Report is ready to be retrieved. Once this webhook has fired, the report will be available to retrieve for 24 hours.
/// </summary>
public record CraCheckReportReadyWebhook
{
    /// <summary>
    /// <c>CHECK_REPORT</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>CHECK_REPORT_READY</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>user_id</c> corresponding to the user the webhook has fired for.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// Specifies a list of products that have successfully been generated for the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("successful_products")]
    public IReadOnlyList<Products?>? SuccessfulProducts { get; init; }

    /// <summary>
    /// Specifies a list of products that have failed to generate for the report. Additional detail on what caused the failure can be found by calling the product /get endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_products")]
    public IReadOnlyList<Products?>? FailedProducts { get; init; }

    /// <summary>
    /// A list of <c>item_ids</c> included in the Check Report. Access to this field is in closed beta.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_ids")]
    public IReadOnlyList<string?>? ItemIds { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
