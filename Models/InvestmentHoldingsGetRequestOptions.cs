using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/investments/holdings/get</c> results. If provided, must not be <c>null</c>.
/// </summary>
public record InvestmentHoldingsGetRequestOptions
{
    /// <summary>
    /// An array of <c>account_id</c>s to retrieve for the Item. An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
