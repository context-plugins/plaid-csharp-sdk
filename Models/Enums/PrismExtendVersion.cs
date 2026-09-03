using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism Extend
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismExtendVersion>))]
public sealed record PrismExtendVersion : StringEnum<PrismExtendVersion>
{
    private PrismExtendVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>4.1</c> Prism Extend version.
    /// </summary>
    public static readonly PrismExtendVersion _41 = new("4.1");

    /// <summary>
    /// The <c>4</c> Prism Extend version.
    /// </summary>
    public static readonly PrismExtendVersion _4 = new("4");

    public static PrismExtendVersion FromValue(string value) => FromValueCore(value);
}
