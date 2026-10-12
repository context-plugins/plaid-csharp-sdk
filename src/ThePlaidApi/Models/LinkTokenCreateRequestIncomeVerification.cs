using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Income product. This field is required if <c>income_verification</c> is included in the <c>products</c> array.
/// </summary>
public record LinkTokenCreateRequestIncomeVerification
{
    /// <summary>
    /// The <c>income_verification_id</c> of the verification instance, as provided by <c>/income/verification/create</c>. Replaced by the user token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_verification_id")]
    public string? IncomeVerificationId { get; init; }

    /// <summary>
    /// The <c>asset_report_id</c> of an asset report associated with the user, as provided by <c>/asset_report/create</c>. Providing an <c>asset_report_id</c> is optional and can be used to verify the user through a streamlined flow. If provided, the bank linking flow will be skipped.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("asset_report_id")]
    public string? AssetReportId { get; init; }

    /// <summary>
    /// An array of access tokens corresponding to Items that a user has previously connected with. Data from these institutions will be cross-referenced with document data received during the Document Income flow to help verify that the uploaded documents are accurate. If the <c>transactions</c> product was not initialized for these Items during Link, it will be initialized after this Link session.
    /// <para>
    /// This field should only be used with the <c>payroll</c> income source type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_tokens")]
    public IReadOnlyList<string>? AccessTokens { get; init; }

    /// <summary>
    /// The types of source income data that users will be permitted to share. Options include <c>bank</c> and <c>payroll</c>. Currently you can only specify one of these options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_source_types")]
    public IReadOnlyList<IncomeVerificationSourceType>? IncomeSourceTypes { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with Bank Income. This field is required if <c>income_verification</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>income_source_types</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income")]
    public LinkTokenCreateRequestIncomeVerificationBankIncome? BankIncome { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with Payroll Income (including Document Income). Further customization options for Document Income, such as customizing which document types may be uploaded, are also available via the <see href="https://dashboard.plaid.com/link">Link Customization pane</see> in the Dashboard. (Requires Production enablement.)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payroll_income")]
    public LinkTokenCreateRequestIncomeVerificationPayrollIncome? PayrollIncome { get; init; }

    /// <summary>
    /// A list of user stated income sources
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stated_income_sources")]
    public IReadOnlyList<LinkTokenCreateRequestUserStatedIncomeSource>? StatedIncomeSources { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
