using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the overall network status of the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkStatusGetResponseNetworkStatus>))]
public sealed record NetworkStatusGetResponseNetworkStatus : StringEnum<NetworkStatusGetResponseNetworkStatus>
{
    private NetworkStatusGetResponseNetworkStatus(string value) : base(value)
    {
    }

    public static readonly NetworkStatusGetResponseNetworkStatus Unknown = new("UNKNOWN");

    public static readonly NetworkStatusGetResponseNetworkStatus ReturningUser = new("RETURNING_USER");

    public static NetworkStatusGetResponseNetworkStatus FromValue(string value) => FromValueCore(value);
}
