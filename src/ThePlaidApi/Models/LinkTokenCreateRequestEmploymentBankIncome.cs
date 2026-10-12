using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with Bank Employment. This field is required if <c>employment</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>employment_source_types</c>.
/// </summary>
public record LinkTokenCreateRequestEmploymentBankIncome
{
    /// <summary>
    /// The number of days of data to request for the Bank Employment product.
    /// </summary>
    [JsonPropertyName("days_requested")]
    public required int DaysRequested { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
