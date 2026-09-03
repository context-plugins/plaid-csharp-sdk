using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Risk level for the given risk check type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskLevel>))]
public sealed record RiskLevel : StringEnum<RiskLevel>
{
    private RiskLevel(string value) : base(value)
    {
    }

    public static readonly RiskLevel Low = new("low");

    public static readonly RiskLevel Medium = new("medium");

    public static readonly RiskLevel High = new("high");

    public static RiskLevel FromValue(string value) => FromValueCore(value);
}
