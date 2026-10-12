using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the student named on a Form I-20.
/// </summary>
public record CreditI20Student
{
    /// <summary>
    /// Given name of the student.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// Surname or primary name of the student.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surname_primary_name")]
    public string? SurnamePrimaryName { get; init; }

    /// <summary>
    /// Name of the student as it appears on their passport.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passport_name")]
    public string? PassportName { get; init; }

    /// <summary>
    /// Preferred name of the student.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preferred_name")]
    public string? PreferredName { get; init; }

    /// <summary>
    /// Name of the school issuing the Form I-20.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("school_name")]
    public string? SchoolName { get; init; }

    /// <summary>
    /// Start date of the program in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("program_start_date")]
    public DateTimeOffset? ProgramStartDate { get; init; }

    /// <summary>
    /// End date of the program in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("program_end_date")]
    public DateTimeOffset? ProgramEndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
