using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Configuration for the FICO products used in the Partner Insights product.
/// </summary>
public record CraPartnerInsightsFicoInput
{
    /// <summary>
    /// ID provided by FICO that uniquely identifies the lender. Required for UltraFICO® score generation. Sometimes referred to as Lender Org ID.
    /// </summary>
    [JsonPropertyName("fico_lender_id")]
    public required string FicoLenderId { get; init; }

    /// <summary>
    /// Client-generated identifier that uniquely identifies the FICO Application across FICO systems.
    /// </summary>
    [JsonPropertyName("lender_application_id")]
    public required string LenderApplicationId { get; init; }

    /// <summary>
    /// A list of UltraFICO® scoring requests. Each request contains all configuration required to generate an UltraFICO score.
    /// </summary>
    [JsonPropertyName("ultrafico_score_requests")]
    public required IReadOnlyList<CraPartnerInsightsUltraFicoScoreRequest> UltraficoScoreRequests { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
