using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Taxpayer ID of the individual receiving the paystub.
/// </summary>
public record PaystubOverrideTaxpayerId
{
    /// <summary>
    /// Type of ID, e.g. 'SSN'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_type")]
    public string? IdType { get; init; }

    /// <summary>
    /// ID mask; i.e. last 4 digits of the taxpayer ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_mask")]
    public string? IdMask { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
