using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxCraCashflowUpdatesUpdateRequest defines the request schema for <c>/sandbox/cra/cashflow_updates/update</c>
/// </summary>
public record SandboxCraCashflowUpdatesUpdateRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The user token associated with the user for which data is being requested. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_token")]
    public string? UserToken { get; init; }

    /// <summary>
    /// Webhook codes corresponding to the Cash Flow Updates events to be simulated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_codes")]
    public IReadOnlyList<CashFlowUpdatesEventWebhookCodes>? WebhookCodes { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
