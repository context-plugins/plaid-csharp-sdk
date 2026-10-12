using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/sandbox/oauth/select_accounts</c>
/// </summary>
public record SandboxOauthSelectAccountsRequest
{
    [JsonPropertyName("oauth_state_id")]
    public required string OauthStateId { get; init; }

    [JsonPropertyName("accounts")]
    public required IReadOnlyList<string> Accounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
