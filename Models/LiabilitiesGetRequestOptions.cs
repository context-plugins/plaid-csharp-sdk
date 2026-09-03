using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/liabilities/get</c> results. If provided, <c>options</c> cannot be null.
/// </summary>
public record LiabilitiesGetRequestOptions
{
    /// <summary>
    /// A list of accounts to retrieve for the Item.
    /// <para>
    /// An error will be returned if a provided <c>account_id</c> is not associated with the Item
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
