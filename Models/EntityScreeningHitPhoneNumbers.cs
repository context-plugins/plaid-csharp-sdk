using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Phone number information associated with the entity screening hit
/// </summary>
public record EntityScreeningHitPhoneNumbers
{
    /// <summary>
    /// An enum indicating whether a phone number is a phone line or a fax line.
    /// </summary>
    [JsonPropertyName("type")]
    public required PhoneType Type { get; init; }

    /// <summary>
    /// A phone number in E.164 format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
