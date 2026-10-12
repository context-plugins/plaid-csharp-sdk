using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/beacon/account_risk/v1/evaluate</c> results to a subset of the accounts on the linked Item.
/// </summary>
public record BeaconAccountRiskEvaluateRequestOptions
{
    /// <summary>
    /// An array of <c>account_ids</c> for the specific accounts to evaluate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
