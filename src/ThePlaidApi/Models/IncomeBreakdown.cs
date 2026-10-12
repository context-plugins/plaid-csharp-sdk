using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing a breakdown of the different income types on the paystub.
/// </summary>
public record IncomeBreakdown
{
    /// <summary>
    /// The type of income. Possible values include:
    ///   <c>"regular"</c>: regular income
    ///   <c>"overtime"</c>: overtime income
    ///   <c>"bonus"</c>: bonus income
    /// </summary>
    [JsonPropertyName("type")]
    public required IncomeBreakdownType? Type { get; init; }

    /// <summary>
    /// The hourly rate at which the income is paid.
    /// </summary>
    [JsonPropertyName("rate")]
    public required double? Rate { get; init; }

    /// <summary>
    /// The number of hours logged for this income for this pay period.
    /// </summary>
    [JsonPropertyName("hours")]
    public required double? Hours { get; init; }

    /// <summary>
    /// The total pay for this pay period.
    /// </summary>
    [JsonPropertyName("total")]
    public required double? Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
