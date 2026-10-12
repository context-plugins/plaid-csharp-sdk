using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// UserAccountSessionGetResponse defines the response schema for <c>/user_account/session/get</c>
/// </summary>
public record UserAccountSessionGetResponse
{
    /// <summary>
    /// The identity data permissioned by the end user during the authorization flow.
    /// </summary>
    [JsonPropertyName("identity")]
    public required UserAccountIdentity? Identity { get; init; }

    [JsonPropertyName("items")]
    public required IReadOnlyList<UserAccountItem> Items { get; init; }

    /// <summary>
    /// Statistics tracking the number of edits made to identity fields over various time periods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identity_edit_history")]
    public UserAccountIdentityEditHistory? IdentityEditHistory { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
