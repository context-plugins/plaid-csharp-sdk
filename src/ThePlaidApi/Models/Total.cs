using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing both the current pay period and year to date amount for a category.
/// </summary>
public record Total
{
    /// <summary>
    /// Commonly used term to describe the line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canonical_description")]
    public TotalCanonicalDescription? CanonicalDescription { get; init; }

    /// <summary>
    /// Text of the line item as printed on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// An object representing a monetary amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_pay")]
    public Pay? CurrentPay { get; init; }

    /// <summary>
    /// An object representing a monetary amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ytd_pay")]
    public Pay? YtdPay { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
