using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Deprecated, use <c>partner_insights.prism_versions</c> instead.
/// </summary>
public record PrismVersionsDeprecated
{
    /// <summary>
    /// The version of Prism FirstDetect. If not specified, will default to v3.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstdetect")]
    public PrismFirstDetectVersion? Firstdetect { get; init; }

    /// <summary>
    /// The version of Prism Detect
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detect")]
    public PrismDetectVersion? Detect { get; init; }

    /// <summary>
    /// The version of Prism CashScore. If not specified, will default to v3.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashscore")]
    public PrismCashScoreVersion? Cashscore { get; init; }

    /// <summary>
    /// The version of Prism Extend
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extend")]
    public PrismExtendVersion? Extend { get; init; }

    /// <summary>
    /// The version of Prism Insights. If not specified, will default to v3.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insights")]
    public PrismInsightsVersion? Insights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
