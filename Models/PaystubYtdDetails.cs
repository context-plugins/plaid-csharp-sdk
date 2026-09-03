using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The amount of income earned year to date, as based on paystub data.
/// </summary>
public record PaystubYtdDetails
{
    /// <summary>
    /// Year-to-date gross earnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_earnings")]
    public double? GrossEarnings { get; init; }

    /// <summary>
    /// Year-to-date net (take home) earnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_earnings")]
    public double? NetEarnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
