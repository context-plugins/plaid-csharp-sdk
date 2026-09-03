using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The object containing a set of ids related to an employee.
/// </summary>
public record CreditPlatformIds
{
    /// <summary>
    /// The ID of an employee as given by their employer.
    /// </summary>
    [JsonPropertyName("employee_id")]
    public required string? EmployeeId { get; init; }

    /// <summary>
    /// The ID of an employee as given by their payroll.
    /// </summary>
    [JsonPropertyName("payroll_id")]
    public required string? PayrollId { get; init; }

    /// <summary>
    /// The ID of the position of the employee.
    /// </summary>
    [JsonPropertyName("position_id")]
    public required string? PositionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
