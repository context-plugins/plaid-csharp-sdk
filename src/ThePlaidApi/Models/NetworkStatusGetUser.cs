using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object specifying information about the end user for the network status check.
/// </summary>
public record NetworkStatusGetUser
{
    /// <summary>
    /// The user's phone number in <see href="https://en.wikipedia.org/wiki/E.164">E.164</see> format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
