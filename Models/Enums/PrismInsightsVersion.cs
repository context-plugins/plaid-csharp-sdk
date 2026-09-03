using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism Insights. If not specified, will default to v3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismInsightsVersion>))]
public sealed record PrismInsightsVersion : StringEnum<PrismInsightsVersion>
{
    private PrismInsightsVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>4.1</c> Prism Insights version.
    /// </summary>
    public static readonly PrismInsightsVersion _41 = new("4.1");

    /// <summary>
    /// The <c>4</c> Prism Insights version.
    /// </summary>
    public static readonly PrismInsightsVersion _4 = new("4");

    /// <summary>
    /// The <c>3</c> Prism Insights version.
    /// </summary>
    public static readonly PrismInsightsVersion _3 = new("3");

    public static PrismInsightsVersion FromValue(string value) => FromValueCore(value);
}
