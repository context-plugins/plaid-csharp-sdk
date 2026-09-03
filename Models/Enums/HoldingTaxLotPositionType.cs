using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether a holding lot position is long or short. Possible values are <c>LONG</c> and <c>SHORT</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HoldingTaxLotPositionType>))]
public sealed record HoldingTaxLotPositionType : StringEnum<HoldingTaxLotPositionType>
{
    private HoldingTaxLotPositionType(string value) : base(value)
    {
    }

    public static readonly HoldingTaxLotPositionType Long = new("LONG");

    public static readonly HoldingTaxLotPositionType Short = new("SHORT");

    public static HoldingTaxLotPositionType FromValue(string value) => FromValueCore(value);
}
