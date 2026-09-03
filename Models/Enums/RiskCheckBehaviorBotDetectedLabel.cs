using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Field describing the outcome of a bot detection behavior risk check.
/// <para>
/// <c>yes</c> indicates that automated activity was detected.
/// </para>
/// <para>
/// <c>no</c> indicates that automated activity was not detected.
/// </para>
/// <para>
/// <c>no_data</c> indicates there was not enough information available to give an accurate signal.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckBehaviorBotDetectedLabel>))]
public sealed record RiskCheckBehaviorBotDetectedLabel : StringEnum<RiskCheckBehaviorBotDetectedLabel>
{
    private RiskCheckBehaviorBotDetectedLabel(string value) : base(value)
    {
    }

    public static readonly RiskCheckBehaviorBotDetectedLabel Yes = new("yes");

    public static readonly RiskCheckBehaviorBotDetectedLabel No = new("no");

    public static readonly RiskCheckBehaviorBotDetectedLabel NoData = new("no_data");

    public static RiskCheckBehaviorBotDetectedLabel FromValue(string value) => FromValueCore(value);
}
