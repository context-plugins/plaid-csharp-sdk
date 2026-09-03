using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing employment details found on a paystub.
/// </summary>
public record EmploymentDetails
{
    /// <summary>
    /// An object representing a monetary amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annual_salary")]
    public Pay? AnnualSalary { get; init; }

    /// <summary>
    /// Date on which the employee was hired, in the YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hire_date")]
    public DateTimeOffset? HireDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
