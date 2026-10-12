using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The legal name and other information for the account holder.
/// </summary>
public record TransferUserInResponse
{
    /// <summary>
    /// The user's legal name.
    /// </summary>
    [JsonPropertyName("legal_name")]
    public required string LegalName { get; init; }

    /// <summary>
    /// The user's phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string? PhoneNumber { get; init; }

    /// <summary>
    /// The user's email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public required string? EmailAddress { get; init; }

    /// <summary>
    /// The address associated with the account holder.
    /// </summary>
    [JsonPropertyName("address")]
    public required TransferUserAddressInResponse? Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
