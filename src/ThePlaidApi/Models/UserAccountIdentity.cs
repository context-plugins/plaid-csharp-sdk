using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The identity data permissioned by the end user during the authorization flow.
/// </summary>
public record UserAccountIdentity
{
    /// <summary>
    /// The user's first name and last name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public UserAccountIdentityName? Name { get; init; }

    /// <summary>
    /// The user's address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public UserAccountIdentityAddress? Address { get; init; }

    /// <summary>
    /// The user's phone number in <see href="https://en.wikipedia.org/wiki/E.164">E.164</see> format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The user's email address.
    /// <para>
    /// Note: email is currently not returned.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The user's date of birth.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public string? DateOfBirth { get; init; }

    /// <summary>
    /// The user's Social Security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn")]
    public string? Ssn { get; init; }

    /// <summary>
    /// The last 4 digits of the user's Social Security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn_last_4")]
    public string? SsnLast4 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
