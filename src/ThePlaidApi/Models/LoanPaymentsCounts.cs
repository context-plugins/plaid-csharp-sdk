using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details regarding the number of loan payments
/// </summary>
public record LoanPaymentsCounts
{
    /// <summary>
    /// The number of loan payments made in the 30 days before the subscription date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseline_count")]
    public double? BaselineCount { get; init; }

    /// <summary>
    /// The current number of loan payments made in the last 30 days
    /// </summary>
    [JsonPropertyName("current_count")]
    public required double CurrentCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
