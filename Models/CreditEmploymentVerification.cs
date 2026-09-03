using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The object containing proof of employment data for an individual.
/// </summary>
public record CreditEmploymentVerification
{
    /// <summary>
    /// ID of the payroll provider account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    /// <summary>
    /// Current employment status.
    /// </summary>
    [JsonPropertyName("status")]
    public required string? Status { get; init; }

    /// <summary>
    /// Start of employment in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// End of employment, if applicable. Provided in ISO 8601 format (YYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// An object containing employer data.
    /// </summary>
    [JsonPropertyName("employer")]
    public required CreditEmployerVerification Employer { get; init; }

    /// <summary>
    /// Current title of employee.
    /// </summary>
    [JsonPropertyName("title")]
    public required string? Title { get; init; }

    /// <summary>
    /// The object containing a set of ids related to an employee.
    /// </summary>
    [JsonPropertyName("platform_ids")]
    public required CreditPlatformIds PlatformIds { get; init; }

    /// <summary>
    /// The type of employment for the individual.
    /// <c>"FULL_TIME"</c>: A full-time employee.
    /// <c>"PART_TIME"</c>: A part-time employee.
    /// <c>"CONTRACTOR"</c>: An employee typically hired externally through a contracting group.
    /// <c>"TEMPORARY"</c>: A temporary employee.
    /// <c>"OTHER"</c>: The employee type is not one of the above defined types.
    /// </summary>
    [JsonPropertyName("employee_type")]
    public required string? EmployeeType { get; init; }

    /// <summary>
    /// The date of the employee's most recent paystub in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("last_paystub_date")]
    public required DateTimeOffset? LastPaystubDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
