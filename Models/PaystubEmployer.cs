using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the employer on the paystub
/// </summary>
public record PaystubEmployer
{
    /// <summary>
    /// Address on the paystub
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public PaystubAddress? Address { get; init; }

    /// <summary>
    /// The name of the employer on the paystub.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
