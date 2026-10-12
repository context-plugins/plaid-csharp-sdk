using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The set of results for a Link session.
/// </summary>
public record LinkSessionResults
{
    /// <summary>
    /// The set of Item adds for the Link session. If you are not receiving this field and are instead receiving the deprecated <c>on_success</c> field, contact your account manager to update your integration.
    /// </summary>
    [JsonPropertyName("item_add_results")]
    public required IReadOnlyList<LinkSessionItemAddResult> ItemAddResults { get; init; }

    /// <summary>
    /// The set of Plaid Check Item adds for the Link session.
    /// </summary>
    [JsonPropertyName("cra_item_add_results")]
    public required IReadOnlyList<LinkSessionCraItemAddResult> CraItemAddResults { get; init; }

    /// <summary>
    /// The set of Plaid Check Item updates for the Link session.
    /// </summary>
    [JsonPropertyName("cra_update_results")]
    public required IReadOnlyList<LinkSessionCraUpdateResult> CraUpdateResults { get; init; }

    /// <summary>
    /// The set of bank income verifications for the Link session.
    /// </summary>
    [JsonPropertyName("bank_income_results")]
    public required IReadOnlyList<LinkSessionBankIncomeResult> BankIncomeResults { get; init; }

    /// <summary>
    /// The set of payroll income verifications for the Link session.
    /// </summary>
    [JsonPropertyName("payroll_income_results")]
    public required IReadOnlyList<LinkSessionPayrollIncomeResult> PayrollIncomeResults { get; init; }

    /// <summary>
    /// The details of a document income verification in Link
    /// </summary>
    [JsonPropertyName("document_income_results")]
    public required CreditSessionDocumentIncomeResult? DocumentIncomeResults { get; init; }

    /// <summary>
    /// The details of a document upload CRA session in Link
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cra_document_upload_results")]
    public LinkSessionCraDocumentUploadResult? CraDocumentUploadResults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
