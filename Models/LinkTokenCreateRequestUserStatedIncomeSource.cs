using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies user stated income sources for the Income product
/// </summary>
public record LinkTokenCreateRequestUserStatedIncomeSource
{
    /// <summary>
    /// The employer corresponding to an income source specified by the user
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer")]
    public string? Employer { get; init; }

    /// <summary>
    /// The income category for a specified income source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public UserStatedIncomeSourceCategory? Category { get; init; }

    /// <summary>
    /// The income amount paid per cycle for a specified income source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_per_cycle")]
    public double? PayPerCycle { get; init; }

    /// <summary>
    /// The income amount paid annually for a specified income source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_annual")]
    public double? PayAnnual { get; init; }

    /// <summary>
    /// The pay type - <c>GROSS</c>, <c>NET</c>, or <c>UNKNOWN</c> for a specified income source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_type")]
    public UserStatedIncomeSourcePayType? PayType { get; init; }

    /// <summary>
    /// The pay frequency of a specified income source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_frequency")]
    public UserStatedIncomeSourceFrequency? PayFrequency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
