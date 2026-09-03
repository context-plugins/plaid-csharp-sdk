using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism Detect
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismDetectVersion>))]
public sealed record PrismDetectVersion : StringEnum<PrismDetectVersion>
{
    private PrismDetectVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>4.1</c> Prism Detect version.
    /// </summary>
    public static readonly PrismDetectVersion _41 = new("4.1");

    /// <summary>
    /// The <c>4</c> Prism Detect version.
    /// </summary>
    public static readonly PrismDetectVersion _4 = new("4");

    public static PrismDetectVersion FromValue(string value) => FromValueCore(value);
}
