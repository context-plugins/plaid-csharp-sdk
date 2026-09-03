using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.
/// </summary>
public record CashflowReportTransactionsGetRequestOptions
{
    /// <summary>
    /// A list of <c>account_ids</c> to retrieve for the Item
    /// <para>
    /// Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
