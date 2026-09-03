using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxItemResetLoginResponse defines the response schema for <c>/sandbox/item/reset_login</c>
/// </summary>
public record SandboxItemResetLoginResponse
{
    /// <summary>
    /// <c>true</c> if the call succeeded
    /// </summary>
    [JsonPropertyName("reset_login")]
    public required bool ResetLogin { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
