using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Identity object used to specify document upload
/// </summary>
public record LinkTokenCreateIdentity
{
    /// <summary>
    /// Used to specify whether the Link session is Identity Document Upload
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_document_upload")]
    public bool? IsDocumentUpload { get; init; }

    /// <summary>
    /// An array of <c>account_ids</c>. Currently can only contain one <c>account_id</c>. Must be populated if using Document Upload.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    /// <summary>
    /// An array of parsing configurations. Valid parsing configurations are <c>ocr</c> and <c>risk_signals</c>. If parsing configurations are omitted, defaults to <c>ocr</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parsing_configs")]
    public IReadOnlyList<IncomeVerificationDocParsingConfig>? ParsingConfigs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
