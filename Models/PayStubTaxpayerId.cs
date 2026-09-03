using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Taxpayer ID of the individual receiving the paystub.
/// </summary>
public record PayStubTaxpayerId
{
    /// <summary>
    /// Type of ID, e.g. 'SSN'.
    /// </summary>
    [JsonPropertyName("id_type")]
    public required string? IdType { get; init; }

    /// <summary>
    /// ID mask; i.e. last 4 digits of the taxpayer ID.
    /// </summary>
    [JsonPropertyName("id_mask")]
    public required string? IdMask { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
