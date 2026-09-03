using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing Layer-related metadata for the requested user.
/// </summary>
public record NetworkStatusGetResponseLayer
{
    /// <summary>
    /// Indicates if the user is eligible for a Layer session.
    /// </summary>
    [JsonPropertyName("eligible")]
    public required bool Eligible { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
