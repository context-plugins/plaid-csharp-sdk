using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The scopes object
/// </summary>
public record ScopesNullable
{
    /// <summary>
    /// The product access being requested. Used to allow or disallow product access across all accounts. If unset, defaults to all products allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_access")]
    public ProductAccess? ProductAccess { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<AccountAccess>? Accounts { get; init; }

    /// <summary>
    /// Allow access to newly opened accounts as they are opened. If unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_accounts")]
    public bool? NewAccounts { get; init; } = true;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
