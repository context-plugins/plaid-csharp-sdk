using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Taxpayer ID of the individual receiving the paystub.
/// </summary>
public record TaxpayerId
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

    /// <summary>
    /// Last 4 digits of unique number of ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_4_digits")]
    [StringLength(4, MinimumLength = 4)]
    public string? Last4Digits { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
