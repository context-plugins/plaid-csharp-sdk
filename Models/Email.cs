using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an email address
/// </summary>
public record Email
{
    /// <summary>
    /// The email address.
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    /// <summary>
    /// When <c>true</c>, identifies the email address as the primary email on an account.
    /// </summary>
    [JsonPropertyName("primary")]
    public required bool Primary { get; init; }

    /// <summary>
    /// The type of email account as described by the financial institution.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type1 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
