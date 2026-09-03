using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Allow or disallow product access by account. Unlisted (e.g. missing) accounts will be considered <c>new_accounts</c>.
/// </summary>
public record AccountAccess
{
    /// <summary>
    /// The unique account identifier for this account. This value must match that returned by the data access API for this account.
    /// </summary>
    [JsonPropertyName("unique_id")]
    public required string UniqueId { get; init; }

    /// <summary>
    /// Allow the application to see this account (and associated details, including balance) in the list of accounts. If unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("authorized")]
    public bool? Authorized { get; init; } = true;

    /// <summary>
    /// Allow the application to access specific products on this account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_product_access")]
    public AccountProductAccessNullable? AccountProductAccess { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
