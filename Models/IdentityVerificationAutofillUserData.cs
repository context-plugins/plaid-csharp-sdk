using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// User information that was autofilled. All this information should be confirmed by the user before using.
/// </summary>
public record IdentityVerificationAutofillUserData
{
    /// <summary>
    /// The full name provided by the user. If the user has not submitted their name, this field will be null. Otherwise, both fields are guaranteed to be filled.
    /// </summary>
    [JsonPropertyName("name")]
    public required IdentityVerificationResponseUserName? Name { get; init; }

    /// <summary>
    /// Even if an address has been autofilled, some fields may be null depending on the region's addressing system. For example:
    /// <para>
    /// Addresses from the United Kingdom will not include a region
    /// </para>
    /// <para>
    /// Addresses from Hong Kong will not include postal code
    /// </para>
    /// </summary>
    [JsonPropertyName("address")]
    public required IdentityVerificationAutofillAddress? Address { get; init; }

    /// <summary>
    /// ID number submitted by the user, currently used only for the Identity Verification product. If the user has not submitted this data yet, this field will be <c>null</c>. Otherwise, both fields are guaranteed to be filled.
    /// </summary>
    [JsonPropertyName("id_number")]
    public required UserIdNumber? IdNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
