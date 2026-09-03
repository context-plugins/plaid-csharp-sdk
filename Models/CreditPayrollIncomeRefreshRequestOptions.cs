using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object for <c>/credit/payroll_income/refresh</c> request options.
/// </summary>
public record CreditPayrollIncomeRefreshRequestOptions
{
    /// <summary>
    /// An array of <c>item_id</c>s to be refreshed. Each <c>item_id</c> should uniquely identify a payroll income item. If this field is not provided, all <c>item_id</c>s associated with the <c>user_token</c> will be refreshed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_ids")]
    public IReadOnlyList<string>? ItemIds { get; init; }

    /// <summary>
    /// The URL where Plaid will send the payroll income refresh webhook.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
