using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the Asset Report has been generated and <c>/asset_report/get</c> is ready to be called.  If you attempt to retrieve an Asset Report before this webhook has fired, you'll receive a response with the HTTP status code 400 and a Plaid error code of <c>PRODUCT_NOT_READY</c>.
/// </summary>
public record AssetsProductReadyWebhook
{
    /// <summary>
    /// <c>ASSETS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>PRODUCT_READY</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>asset_report_id</c> corresponding to the Asset Report the webhook has fired for.
    /// </summary>
    [JsonPropertyName("asset_report_id")]
    public required string AssetReportId { get; init; }

    /// <summary>
    /// The <c>user_id</c> corresponding to the User ID the webhook has fired for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// Indicates either a Fast Asset Report, which will contain only current identity and balance information, or a Full Asset Report, which will also contain historical balance information and transaction data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("report_type")]
    public AssetReportType? ReportType { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
