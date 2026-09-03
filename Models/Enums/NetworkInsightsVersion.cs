using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Network Insights. Required if using Network Insights.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkInsightsVersion>))]
public sealed record NetworkInsightsVersion : StringEnum<NetworkInsightsVersion>
{
    private NetworkInsightsVersion(string value) : base(value)
    {
    }

    public static readonly NetworkInsightsVersion Ni1 = new("NI1");

    public static NetworkInsightsVersion FromValue(string value) => FromValueCore(value);
}
