using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with Payroll Income (including Document Income). Further customization options for Document Income, such as customizing which document types may be uploaded, are also available via the <see href="https://dashboard.plaid.com/link">Link Customization pane</see> in the Dashboard. (Requires Production enablement.)
/// </summary>
public record LinkTokenCreateRequestIncomeVerificationPayrollIncome
{
    /// <summary>
    /// The types of payroll income verification to enable for the Link session. If none are specified, then users will see both document and digital payroll income.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flow_types")]
    public IReadOnlyList<IncomeVerificationPayrollFlowType?>? FlowTypes { get; init; }

    /// <summary>
    /// An identifier to indicate whether the income verification Link token will be used for update mode. This field is only relevant for participants in the Payroll Income Refresh beta.
    /// </summary>
    [JsonPropertyName("is_update_mode")]
    public bool? IsUpdateMode { get; init; } = false;

    /// <summary>
    /// Uniquely identify a payroll income Item to update with.  This field is only relevant for participants in the Payroll Income Refresh beta.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id_to_update")]
    public string? ItemIdToUpdate { get; init; }

    /// <summary>
    /// The types of analysis to enable for document uploads. If this field is not provided, then docs will undergo OCR parsing only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parsing_config")]
    public IReadOnlyList<IncomeVerificationDocParsingConfig?>? ParsingConfig { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
