using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The set of results for a Link session.
/// </summary>
public record CreditSessionResults
{
    /// <summary>
    /// The set of Item adds for the Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_add_results")]
    public IReadOnlyList<CreditSessionItemAddResult>? ItemAddResults { get; init; }

    /// <summary>
    /// The set of bank income verifications for the Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income_results")]
    public IReadOnlyList<CreditSessionBankIncomeResult>? BankIncomeResults { get; init; }

    /// <summary>
    /// The set of bank employment verifications for the Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_employment_results")]
    public IReadOnlyList<CreditSessionBankEmploymentResult>? BankEmploymentResults { get; init; }

    /// <summary>
    /// The set of payroll income verifications for the Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payroll_income_results")]
    public IReadOnlyList<CreditSessionPayrollIncomeResult>? PayrollIncomeResults { get; init; }

    /// <summary>
    /// The details of a document income verification in Link
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_income_results")]
    public CreditSessionDocumentIncomeResult? DocumentIncomeResults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
