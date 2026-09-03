using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Autofill represents unverified customer information. This needs to be confirmed by the customer before using.
/// </summary>
public record IdentityVerificationAutofillCreateResponse
{
    /// <summary>
    /// A status enum indicating whether autofill succeeded or failed.
    /// </summary>
    [JsonPropertyName("status")]
    public required IdentityVerificationAutofillStatus Status { get; init; }

    /// <summary>
    /// User information that was autofilled. All this information should be confirmed by the user before using.
    /// </summary>
    [JsonPropertyName("user")]
    public required IdentityVerificationAutofillUserData? User { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
