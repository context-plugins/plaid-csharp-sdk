using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for Bank Income. This field is required if <c>income_verification</c> is included in the <c>initial_products</c> array and <c>bank</c> is specified in <c>income_source_types</c>.
/// </summary>
public record SandboxPublicTokenCreateRequestIncomeVerificationBankIncome
{
    /// <summary>
    /// The number of days of data to request for the Bank Income product
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    public int? DaysRequested { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
