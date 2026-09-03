using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AccountsGetResponse defines the response schema for <c>/accounts/get</c> and <c>/accounts/balance/get</c>.
/// </summary>
public record AccountsGetResponse
{
    /// <summary>
    /// An array of financial institution accounts associated with the Item.
    /// If <c>/accounts/balance/get</c> was called, each account will include real-time balance information.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<Account> Accounts { get; init; }

    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
