using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Risk level for the given risk check type, when available.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskLevelWithNoData>))]
public sealed record RiskLevelWithNoData : StringEnum<RiskLevelWithNoData>
{
    private RiskLevelWithNoData(string value) : base(value)
    {
    }

    public static readonly RiskLevelWithNoData Low = new("low");

    public static readonly RiskLevelWithNoData Medium = new("medium");

    public static readonly RiskLevelWithNoData High = new("high");

    public static readonly RiskLevelWithNoData NoData = new("no_data");

    public static RiskLevelWithNoData FromValue(string value) => FromValueCore(value);
}
