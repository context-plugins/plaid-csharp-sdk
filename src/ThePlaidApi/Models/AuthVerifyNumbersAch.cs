using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ACH numbers for verification via Database Auth
/// </summary>
public record AuthVerifyNumbersAch
{
    /// <summary>
    /// Account's account number
    /// </summary>
    [JsonPropertyName("account")]
    public required string Account { get; init; }

    /// <summary>
    /// Account's routing number
    /// </summary>
    [JsonPropertyName("routing")]
    public required string Routing { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
