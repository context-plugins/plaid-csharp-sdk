using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the device being used to initiate the authorization.
/// </summary>
public record TransferDevice
{
    /// <summary>
    /// The IP address of the device being used to initiate the authorization.
    /// </summary>
    [JsonPropertyName("ip_address")]
    public required string IpAddress { get; init; }

    /// <summary>
    /// The user agent of the device being used to initiate the authorization.
    /// </summary>
    [JsonPropertyName("user_agent")]
    public required string UserAgent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
