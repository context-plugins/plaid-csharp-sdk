using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The Prism Data insights for the user.
/// </summary>
public record CraPartnerInsightsPrism
{
    /// <summary>
    /// The data from the Insights product returned by Prism Data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insights")]
    public PrismInsights? Insights { get; init; }

    /// <summary>
    /// The data from the CashScore® product returned by Prism Data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_score")]
    public PrismCashScore? CashScore { get; init; }

    /// <summary>
    /// The data from the CashScore® Extend product returned by Prism Data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extend")]
    public PrismExtend? Extend { get; init; }

    /// <summary>
    /// The data from the FirstDetect product returned by Prism Data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first_detect")]
    public PrismFirstDetect? FirstDetect { get; init; }

    /// <summary>
    /// The data from the CashScore® Detect product returned by Prism Data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detect")]
    public PrismDetect? Detect { get; init; }

    /// <summary>
    /// Details on whether the Prism Data attributes succeeded or failed to be generated.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
