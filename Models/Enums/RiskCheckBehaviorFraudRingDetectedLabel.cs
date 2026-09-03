using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Field describing the outcome of a fraud ring behavior risk check.
/// <para>
/// <c>yes</c> indicates that fraud ring activity was detected.
/// </para>
/// <para>
/// <c>no</c> indicates that fraud ring activity was not detected.
/// </para>
/// <para>
/// <c>no_data</c> indicates there was not enough information available to give an accurate signal.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckBehaviorFraudRingDetectedLabel>))]
public sealed record RiskCheckBehaviorFraudRingDetectedLabel : StringEnum<RiskCheckBehaviorFraudRingDetectedLabel>
{
    private RiskCheckBehaviorFraudRingDetectedLabel(string value) : base(value)
    {
    }

    public static readonly RiskCheckBehaviorFraudRingDetectedLabel Yes = new("yes");

    public static readonly RiskCheckBehaviorFraudRingDetectedLabel No = new("no");

    public static readonly RiskCheckBehaviorFraudRingDetectedLabel NoData = new("no_data");

    public static RiskCheckBehaviorFraudRingDetectedLabel FromValue(string value) => FromValueCore(value);
}
