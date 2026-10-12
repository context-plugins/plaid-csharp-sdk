using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object for <c>/credit/bank_income/get</c> request options.
/// </summary>
public record CreditBankIncomeGetRequestOptions
{
    /// <summary>
    /// How many Bank Income Reports should be fetched. Multiple reports may be available if the report has been re-created or refreshed. If more than one report is available, the most recent reports will be returned first.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; } = 1;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
