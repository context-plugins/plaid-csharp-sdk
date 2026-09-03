using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Configuration parameters for Hosted Link. To enable the session for Hosted Link, send this object in the request. It can be empty.
/// </summary>
public record LinkTokenCreateHostedLink
{
    /// <summary>
    /// How Plaid should deliver the Plaid Link session to the customer. Only available to customers enabled for Link Delivery (beta). To request Link Delivery access, contact your account manager.
    /// 'sms' will deliver via SMS. Must pass <c>user.phone_number</c>.
    /// 'email' will deliver via email. Must pass <c>user.email_address</c>. In the Sandbox environment, this field will be ignored; use the Production environment to test Link Delivery instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delivery_method")]
    public HostedLinkDeliveryMethod? DeliveryMethod { get; init; }

    /// <summary>
    /// URI that Hosted Link will redirect to upon completion of the Link flow. This will only occur in Hosted Link sessions, not in other implementation methods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completion_redirect_uri")]
    public string? CompletionRedirectUri { get; init; }

    /// <summary>
    /// How many seconds the link will be valid for. Must be positive. Cannot be longer than 21 days. The default lifetime is 7 days for links delivered by email, 1 day for links delivered via SMS, and 30 minutes for links not sent via Plaid Link delivery. This parameter will override the value of all three link types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url_lifetime_seconds")]
    public int? UrlLifetimeSeconds { get; init; }

    /// <summary>
    /// This indicates whether the client is opening Hosted Link in a mobile app in an <c>AsWebAuthenticationSession</c> or Chrome custom tab.
    /// </summary>
    [JsonPropertyName("is_mobile_app")]
    public bool? IsMobileApp { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
