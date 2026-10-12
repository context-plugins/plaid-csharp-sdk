using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/investments/transactions/get</c> results. If provided, must be non-<c>null</c>.
/// </summary>
public record InvestmentsTransactionsGetRequestOptions
{
    /// <summary>
    /// An array of <c>account_ids</c> to retrieve for the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    /// <summary>
    /// The number of transactions to fetch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(500)]
    public int? Count { get; init; } = 100;

    /// <summary>
    /// The number of transactions to skip when fetching transaction history
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset")]
    [Minimum(0)]
    public int? Offset { get; init; } = 0;

    /// <summary>
    /// If the Item was not initialized with the investments product via the <c>products</c>, <c>required_if_supported_products</c>, or <c>optional_products</c> array when calling <c>/link/token/create</c>, and <c>async_update</c> is set to true, the initial Investments extraction will happen asynchronously. Plaid will subsequently fire a <c>HISTORICAL_UPDATE</c> webhook when the extraction completes. When <c>false</c>, Plaid will wait to return a response until extraction completion and no <c>HISTORICAL_UPDATE</c> webhook will fire. Note that while the extraction is happening asynchronously, calls to <c>/investments/transactions/get</c> and <c>/investments/refresh</c> will return <c>PRODUCT_NOT_READY</c> errors until the extraction completes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("async_update")]
    public bool? AsyncUpdate { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
