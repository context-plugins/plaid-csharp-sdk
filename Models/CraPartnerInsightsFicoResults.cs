using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The calculated UltraFICO® scores returned as part of the Partner Insights report.
/// </summary>
public record CraPartnerInsightsFicoResults
{
    /// <summary>
    /// Client-generated identifier that uniquely identifies the FICO Application across FICO systems.
    /// </summary>
    [JsonPropertyName("lender_application_id")]
    public required string LenderApplicationId { get; init; }

    /// <summary>
    /// UltraFICO® scoring results, one per provided UltraFICO scoring request.
    /// </summary>
    [JsonPropertyName("ultrafico_score_results")]
    public required IReadOnlyList<CraPartnerInsightsUltraFicoScoreResult> UltraficoScoreResults { get; init; }

    /// <summary>
    /// Report characteristics returned by FICO describing the banking data used to generate the UltraFICO® score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("report_characteristics")]
    public CraPartnerInsightsFicoReportCharacteristics? ReportCharacteristics { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
