using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A set of parameters for income verification options. This field is required if <c>income_verification</c> is included in the <c>initial_products</c> array.
/// </summary>
public record SandboxPublicTokenCreateRequestOptionsIncomeVerification
{
    /// <summary>
    /// The types of source income data that users will be permitted to share. Options include <c>bank</c> and <c>payroll</c>. Currently you can only specify one of these options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_source_types")]
    public IReadOnlyList<IncomeVerificationSourceType>? IncomeSourceTypes { get; init; }

    /// <summary>
    /// Specifies options for Bank Income. This field is required if <c>income_verification</c> is included in the <c>initial_products</c> array and <c>bank</c> is specified in <c>income_source_types</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income")]
    public SandboxPublicTokenCreateRequestIncomeVerificationBankIncome? BankIncome { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
