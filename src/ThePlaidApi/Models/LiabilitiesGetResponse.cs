using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// LiabilitiesGetResponse defines the response schema for <c>/liabilities/get</c>
/// </summary>
public record LiabilitiesGetResponse
{
    /// <summary>
    /// An array of accounts associated with the Item
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<Account> Accounts { get; init; }

    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// An object containing liability accounts
    /// </summary>
    [JsonPropertyName("liabilities")]
    public required LiabilitiesObject Liabilities { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
