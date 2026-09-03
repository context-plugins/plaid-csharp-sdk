using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism CashScore. If not specified, will default to v3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismCashScoreVersion>))]
public sealed record PrismCashScoreVersion : StringEnum<PrismCashScoreVersion>
{
    private PrismCashScoreVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>4.1</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _41 = new("4.1");

    /// <summary>
    /// The <c>4</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _4 = new("4");

    /// <summary>
    /// The <c>3_lite</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _3Lite = new("3_lite");

    /// <summary>
    /// The <c>3</c> Prism CashScore version.
    /// </summary>
    public static readonly PrismCashScoreVersion _3 = new("3");

    public static PrismCashScoreVersion FromValue(string value) => FromValueCore(value);
}
