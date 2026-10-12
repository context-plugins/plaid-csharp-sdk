using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/auth/get</c> results.
/// </summary>
public record AuthGetRequestOptions
{
    /// <summary>
    /// A list of <c>account_ids</c> to retrieve for the Item.
    /// Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
