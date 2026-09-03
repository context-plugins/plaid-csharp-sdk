using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email address includes the date of birth or year of birth if known.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailIncludesDateOfBirth>))]
public sealed record RiskCheckEmailIncludesDateOfBirth : StringEnum<RiskCheckEmailIncludesDateOfBirth>
{
    private RiskCheckEmailIncludesDateOfBirth(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailIncludesDateOfBirth Yes = new("yes");

    public static readonly RiskCheckEmailIncludesDateOfBirth No = new("no");

    public static readonly RiskCheckEmailIncludesDateOfBirth NoData = new("no_data");

    public static RiskCheckEmailIncludesDateOfBirth FromValue(string value) => FromValueCore(value);
}
