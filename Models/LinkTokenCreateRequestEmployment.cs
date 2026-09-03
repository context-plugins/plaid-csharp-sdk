using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Employment product. This field is required if <c>employment</c> is included in the <c>products</c> array.
/// </summary>
public record LinkTokenCreateRequestEmployment
{
    /// <summary>
    /// The types of source employment data that users will be permitted to share. Options include <c>bank</c> and <c>payroll</c>. Currently you can only specify one of these options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employment_source_types")]
    public IReadOnlyList<EmploymentSourceType>? EmploymentSourceTypes { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with Bank Employment. This field is required if <c>employment</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>employment_source_types</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_employment")]
    public LinkTokenCreateRequestEmploymentBankIncome? BankEmployment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
