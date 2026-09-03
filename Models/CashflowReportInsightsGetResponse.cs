using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CashflowReportInsightsGetResponse defines the response schema for <c>/cashflow_report/insights/get</c>
/// </summary>
public record CashflowReportInsightsGetResponse
{
    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// An array containing the <c>accounts</c> associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the <c>account_id</c> field.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<BusinessAccount> Accounts { get; init; }

    /// <summary>
    /// Insights on the account level. These are only returned for Credit and Depository type accounts.
    /// </summary>
    [JsonPropertyName("account_insights")]
    public required CashflowAccountInsights AccountInsights { get; init; }

    /// <summary>
    /// Datetime of last Cashflow Report generation in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> )
    /// </summary>
    [JsonPropertyName("last_generated_time")]
    public required DateTimeOffset LastGeneratedTime { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
