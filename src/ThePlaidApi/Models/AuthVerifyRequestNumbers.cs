using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing identifying account numbers for verification via Database Auth
/// </summary>
public record AuthVerifyRequestNumbers
{
    /// <summary>
    /// ACH numbers for verification via Database Auth
    /// </summary>
    [JsonPropertyName("ach")]
    public required AuthVerifyNumbersAch Ach { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
