using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information related to the callback from the Hosted Link session.
/// </summary>
public record LinkCallbackMetadata
{
    /// <summary>
    /// The type of Link callback event
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback_type")]
    public LinkDeliveryWebhookCallbackType? CallbackType { get; init; }

    /// <summary>
    /// A string representing the event that has just occurred in the Link flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_name")]
    public LinkEventName? EventName { get; init; }

    /// <summary>
    /// Indicates where in the flow the Link user exited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// A unique identifier associated with a user's actions and events through the Link flow. Include this identifier when opening a support ticket for faster turnaround.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_session_id")]
    public string? LinkSessionId { get; init; }

    /// <summary>
    /// The request ID for the last request made by Link. This can be shared with Plaid support to expedite investigation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    /// <summary>
    /// Information related to the financial institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution")]
    public LinkDeliveryInstitution? Institution { get; init; }

    /// <summary>
    /// A list of accounts attached to the connected Item. If Account Select is enabled via the developer dashboard, accounts will only include selected accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<LinkDeliveryAccount>? Accounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
