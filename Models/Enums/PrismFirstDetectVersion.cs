using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism FirstDetect. If not specified, will default to v3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismFirstDetectVersion>))]
public sealed record PrismFirstDetectVersion : StringEnum<PrismFirstDetectVersion>
{
    private PrismFirstDetectVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>3</c> Prism FirstDetect version.
    /// </summary>
    public static readonly PrismFirstDetectVersion _3 = new("3");

    public static PrismFirstDetectVersion FromValue(string value) => FromValueCore(value);
}
