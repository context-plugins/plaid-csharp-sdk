using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata on whether this income transaction is an outlier.
/// </summary>
public record CraIncomeTransactionOutlier
{
    /// <summary>
    /// Indicates whether an income transaction amount is unusually high compared to the amounts for that stream.
    /// </summary>
    [JsonPropertyName("is_outlier")]
    public required bool IsOutlier { get; init; }

    /// <summary>
    /// The amount that the transaction differs from the stream average transaction amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
