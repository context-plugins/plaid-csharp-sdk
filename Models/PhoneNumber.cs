using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A phone number
/// </summary>
public record PhoneNumber
{
    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    /// <summary>
    /// When <c>true</c>, identifies the phone number as the primary number on an account.
    /// </summary>
    [JsonPropertyName("primary")]
    public required bool Primary { get; init; }

    /// <summary>
    /// The type of phone number.
    /// </summary>
    [JsonPropertyName("type")]
    public required TypeEnum Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
