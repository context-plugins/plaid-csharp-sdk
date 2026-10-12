using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRecurringGetResponse defines the response schema for <c>/transactions/recurring/get</c>
/// </summary>
public record TransactionsRecurringGetResponse
{
    /// <summary>
    /// An array of inflow transaction streams.
    /// </summary>
    [JsonPropertyName("inflow_streams")]
    public required IReadOnlyList<TransactionStream> InflowStreams { get; init; }

    /// <summary>
    /// An array of expense transaction streams.
    /// </summary>
    [JsonPropertyName("outflow_streams")]
    public required IReadOnlyList<TransactionStream> OutflowStreams { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the last time transaction streams for the given account were updated on
    /// </summary>
    [JsonPropertyName("updated_datetime")]
    public required DateTimeOffset UpdatedDatetime { get; init; }

    /// <summary>
    /// Indicates which version of the personal finance category taxonomy is being used. <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">View PFCv2 and PFCv1 taxonomies</see>.
    /// <para>
    /// If you enabled Transactions or Enrich before December 3, 2025 you will receive the <c>v1</c> taxonomy by default and may request <c>v2</c> by explicitly setting this field to <c>v2</c> in the request.
    /// </para>
    /// <para>
    /// If you enabled Transactions or Enrich on or after December 3, 2025, you may only receive the <c>v2</c> taxonomy.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category_version")]
    public PersonalFinanceCategoryVersion? PersonalFinanceCategoryVersion { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
