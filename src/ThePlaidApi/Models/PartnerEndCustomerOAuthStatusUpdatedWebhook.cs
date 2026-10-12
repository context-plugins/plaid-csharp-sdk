using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The webhook of type <c>PARTNER</c> and code <c>END_CUSTOMER_OAUTH_STATUS_UPDATED</c> will be fired when a partner's end customer has an update on their OAuth registration status with an institution.
/// </summary>
public record PartnerEndCustomerOAuthStatusUpdatedWebhook
{
    /// <summary>
    /// <c>PARTNER</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>END_CUSTOMER_OAUTH_STATUS_UPDATED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The client ID of the end customer
    /// </summary>
    [JsonPropertyName("end_customer_client_id")]
    public required string EndCustomerClientId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    /// <summary>
    /// The institution ID
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The institution name
    /// </summary>
    [JsonPropertyName("institution_name")]
    public required string InstitutionName { get; init; }

    /// <summary>
    /// The OAuth status of the update
    /// </summary>
    [JsonPropertyName("status")]
    public required PartnerEndCustomerOAuthStatusUpdatedValues Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
