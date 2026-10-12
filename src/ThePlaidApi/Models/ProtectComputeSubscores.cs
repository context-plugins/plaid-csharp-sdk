using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Per-bucket subscores returned alongside the overall Trust Index score. For cash-advance models, each key maps to an amount-bucket subscore (0-100); higher values indicate lower fraud risk. Only buckets that were scored are included in the response.
/// </summary>
public record ProtectComputeSubscores
{
    /// <summary>
    /// Subscore for cash advance amounts in the range $0-$25.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_advance_bucket_0_25")]
    public int? CashAdvanceBucket025 { get; init; }

    /// <summary>
    /// Subscore for cash advance amounts in the range $25-$50.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_advance_bucket_25_50")]
    public int? CashAdvanceBucket2550 { get; init; }

    /// <summary>
    /// Subscore for cash advance amounts in the range $50-$100.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_advance_bucket_50_100")]
    public int? CashAdvanceBucket50100 { get; init; }

    /// <summary>
    /// Subscore for cash advance amounts in the range $100-$200.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_advance_bucket_100_200")]
    public int? CashAdvanceBucket100200 { get; init; }

    /// <summary>
    /// Subscore for cash advance amounts in the range $200-$300.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_advance_bucket_200_300")]
    public int? CashAdvanceBucket200300 { get; init; }

    /// <summary>
    /// Subscore for cash advance amounts in the range $300-$400.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_advance_bucket_300_400")]
    public int? CashAdvanceBucket300400 { get; init; }

    /// <summary>
    /// Subscore for cash advance amounts in the range $400-$500.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_advance_bucket_400_500")]
    public int? CashAdvanceBucket400500 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
