using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data about the employee.
/// </summary>
public record Employee
{
    /// <summary>
    /// Address on the paystub
    /// </summary>
    [JsonPropertyName("address")]
    public required PaystubAddress Address { get; init; }

    /// <summary>
    /// The name of the employee.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

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
    public TaxpayerId? TaxpayerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
