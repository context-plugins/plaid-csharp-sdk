using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The employee on the paystub.
/// </summary>
public record PaystubOverrideEmployee
{
    /// <summary>
    /// The name of the employee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The address of the employee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public PaystubOverrideEmployeeAddress? Address { get; init; }

    /// <summary>
    /// Marital status of the employee - either <c>single</c> or <c>married</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marital_status")]
    public string? MaritalStatus { get; init; }

    /// <summary>
    /// Taxpayer ID of the individual receiving the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxpayer_id")]
    public PaystubOverrideTaxpayerId? TaxpayerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
