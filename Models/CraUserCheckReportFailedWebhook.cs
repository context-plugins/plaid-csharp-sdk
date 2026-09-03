using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when a Check Report has failed to generate. To get more details, call <c>/user/items/get</c> and check for non-null <c>error</c> objects on the associated Items in the response. These <c>error</c> objects will contain more details on why the Item is in an error state and how to resolve it. After resolving the errors, you can try to re-generate the report.
/// </summary>
public record CraUserCheckReportFailedWebhook
{
    /// <summary>
    /// <c>CHECK_REPORT</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>USER_CHECK_REPORT_FAILED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>user_id</c> associated with the user whose data is being requested. This is received by calling <c>/user/create</c>.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// Details on why the Check Report failed and how to resolve it.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// A list of Items that the end user can repair via Link <see href="https://plaid.com/docs/link/update-mode">update mode</see>. Empty when no Item is user-repairable. After repairing these Items, call <c>/cra/check_report/create</c> to regenerate the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repairable_items")]
    public IReadOnlyList<CheckReportRepairableItem>? RepairableItems { get; init; }

    /// <summary>
    /// Specifies a list of products that failed to generate for the report. Populated when generation was attempted and all requested products failed. Additional detail on what caused the failure can be found by calling the product /get endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_products")]
    public IReadOnlyList<Products>? FailedProducts { get; init; }

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
