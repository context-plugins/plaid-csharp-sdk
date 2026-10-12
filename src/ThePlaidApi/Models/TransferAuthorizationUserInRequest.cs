using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The legal name and other information for the account holder.  If the account has multiple account holders, provide the information for the account holder on whose behalf the authorization is being requested. The <c>user.legal_name</c> field is required. Other fields are not currently used and are present to support planned future functionality.
/// </summary>
public record TransferAuthorizationUserInRequest
{
    /// <summary>
    /// The user's legal name. If the user is a business, provide the business name.
    /// </summary>
    [JsonPropertyName("legal_name")]
    public required string LegalName { get; init; }

    /// <summary>
    /// The user's phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The user's email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The address associated with the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public TransferUserAddressInRequest? Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
