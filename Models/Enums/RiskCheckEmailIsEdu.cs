using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email address domain is an educational institution domain if known.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailIsEdu>))]
public sealed record RiskCheckEmailIsEdu : StringEnum<RiskCheckEmailIsEdu>
{
    private RiskCheckEmailIsEdu(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailIsEdu Yes = new("yes");

    public static readonly RiskCheckEmailIsEdu No = new("no");

    public static readonly RiskCheckEmailIsEdu NoData = new("no_data");

    public static RiskCheckEmailIsEdu FromValue(string value) => FromValueCore(value);
}
