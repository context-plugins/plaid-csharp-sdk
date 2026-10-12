using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A summary across all risk signals associated with a document
/// </summary>
public record DocumentRiskSummary
{
    /// <summary>
    /// A number between 0 and 100, inclusive, where a score closer to 0 indicates a document is likely to be trustworthy and a score closer to 100 indicates a document is likely to be fraudulent. You can automatically reject documents with a high risk score, automatically accept documents with a low risk score, and manually review documents in between. We suggest starting with a threshold of 80 for auto-rejection and 20 for auto-acceptance. As you gather more data points on typical risk scores for your use case, you can tune these parameters to reduce the number of documents undergoing manual review.
    /// </summary>
    [JsonPropertyName("risk_score")]
    public required double? RiskScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
