using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// W2 state and local wages
/// </summary>
public record W2StateAndLocalWages
{
    /// <summary>
    /// State associated with the wage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// State identification number of the employer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer_state_id_number")]
    public string? EmployerStateIdNumber { get; init; }

    /// <summary>
    /// Wages and tips from the specified state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_wages_tips")]
    public string? StateWagesTips { get; init; }

    /// <summary>
    /// Income tax from the specified state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_income_tax")]
    public string? StateIncomeTax { get; init; }

    /// <summary>
    /// Wages and tips from the locality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("local_wages_tips")]
    public string? LocalWagesTips { get; init; }

    /// <summary>
    /// Income tax from the locality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("local_income_tax")]
    public string? LocalIncomeTax { get; init; }

    /// <summary>
    /// Name of the locality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality_name")]
    public string? LocalityName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
